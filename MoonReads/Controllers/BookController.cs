using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Dto;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookController : Controller
	{
        private const string DefaultDescription = "Ta książka nie ma jeszcze opisu";
        private const string DefaultImageUrl = "https://cdn-icons-png.flaticon.com/512/10701/10701484.png";
		private readonly IBookRepository _bookRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IRatingRepository _ratingRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IReactionRepository _reactionRepository;

        public BookController(IBookRepository bookRepository,
            IPublisherRepository publisherRepository,
            IMapper mapper,
            UserManager<User> userManager,
            IRatingRepository ratingRepository,
            IReviewRepository reviewRepository,
            IReactionRepository reactionRepository)
		{
			_bookRepository = bookRepository;
            _publisherRepository = publisherRepository;
            _mapper = mapper;
            _userManager = userManager;
            _ratingRepository = ratingRepository;
            _reviewRepository = reviewRepository;
            _reactionRepository = reactionRepository;
        }

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<BookDetailDto>))]
        public IActionResult GetBooks()
		{
			var books = _mapper.Map<List<BookDetailDto>>(_bookRepository.GetBooks(false));

			if (!ModelState.IsValid)
				return BadRequest(InternalStatusCodes.InvalidPayload);

			return Ok(books);
		}
        
        [HttpGet("{bookId}")]
        [ProducesResponseType(200, Type = typeof(BookDetailDto))]
		[ProducesResponseType(400)]
		public IActionResult GetBook(int bookId)
		{
			if (!_bookRepository.BookExists(bookId))
				return NotFound(InternalStatusCodes.EntityNotExist);

			var book = _mapper.Map<BookDetailDto>(_bookRepository.GetBookDetails(bookId));

            if (book == null)
                return Unauthorized();

            if (!ModelState.IsValid)
				return BadRequest(InternalStatusCodes.InvalidPayload);

			return Ok(book);
		}
        
        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpGet("pending")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BookDetailDto>))]
        public IActionResult GetPendingBooks()
        {
            var books = _mapper.Map<List<BookDetailDto>>(_bookRepository.GetBooks(true));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(books);
        }
        
        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpPut("{bookId}/accept")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BookDetailDto>))]
        public IActionResult AcceptPendingBook(int bookId)
        {
            if (!_bookRepository.BookExists(bookId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var book = _bookRepository.GetBook(bookId);
            book.Pending = false;

            if (!_bookRepository.UpdateBookStatus(book))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateBook([FromQuery] int publisherId, [FromQuery] int[] authorsIds, [FromQuery] int[] categoriesIds, [FromBody] BookDto? bookCreate)
        {
            if (bookCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var books = _bookRepository
                .GetBooks(false)
                .FirstOrDefault(b => b.Title.Trim().ToUpper() == bookCreate.Title.TrimEnd().ToUpper());

            if (books != null)
            {
                return StatusCode(422, InternalStatusCodes.EntityExist);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (bookCreate.Description.IsNullOrEmpty())
            {
                bookCreate.Description = DefaultDescription;
            }

            if (bookCreate.ImageUrl.IsNullOrEmpty())
            {
                bookCreate.ImageUrl = DefaultImageUrl;
            }

            var bookMap = _mapper.Map<Book>(bookCreate);
            
            bookMap.Pending = User.IsInRole(UserRoles.User);

            bookMap.Publisher = _publisherRepository.GetPublisher(publisherId);

            if (!_bookRepository.CreateBook(authorsIds, categoriesIds, bookMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpPut("{bookId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateBook(int bookId, [FromQuery] int publisherId, [FromQuery] int[] authorsIds, [FromQuery] int[] categoriesIds, [FromBody] BookDto? updatedBook)
        {
            if (updatedBook == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (bookId != updatedBook.Id)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_bookRepository.BookExists(bookId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var bookMap = _mapper.Map<Book>(updatedBook);
            bookMap.Pending = false;

            if (!_bookRepository.UpdateBook(publisherId, authorsIds, categoriesIds, bookMap))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpDelete("{bookId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteBook(int bookId)
        {
            if (!_bookRepository.BookExists(bookId))
                return NotFound();

            var book = _bookRepository.GetBook(bookId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_bookRepository.DeleteBook(book))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpGet("{bookId}/rate/user")]
        [ProducesResponseType(200, Type = typeof(RatingShortDto))]
        public IActionResult GetUserRating(int bookId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var rating = _ratingRepository.GetUserRating(bookId, userId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(rating);
        }

        [HttpGet("{bookId}/rate")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<RatingDetailDto>))]
        public IActionResult GetRatings(int bookId)
        {
            var ratings = _ratingRepository.GetRatings(bookId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(ratings);
        }

        [Authorize]
        [HttpPost("{bookId}/rate")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateRating(int bookId, [FromBody] RatingDto? ratingCreate)
        {
            if (ratingCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (!_bookRepository.BookExists(bookId))
                return NotFound(InternalStatusCodes.EntityNotExist);

            var book = _bookRepository.GetBook(bookId);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);

            if (_ratingRepository.UserBookRatingExists(bookId, userId))
                return BadRequest(InternalStatusCodes.EntityExist);

            var ratingMap = _mapper.Map<Rating>(ratingCreate);

            ratingMap.User = user!;
            ratingMap.Book = book;
            
            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_ratingRepository.CreateRating(ratingMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpPatch("rate/{rateId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateRating(int rateId, [FromBody] JsonPatchDocument<Rating>? updatedRating)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var rating = _ratingRepository.GetRating(rateId);
            
            if (updatedRating == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (!_ratingRepository.RatingExists(rateId))
                return NotFound(InternalStatusCodes.EntityNotExist);
            
            if (rating.UserId != userId)
                return BadRequest(InternalStatusCodes.InvalidUser);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_ratingRepository.UpdateRating(updatedRating, rating))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpDelete("rate/{rateId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteRating(int rateId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var user = await _userManager.FindByIdAsync(userId);
            
            var rating = _ratingRepository.GetRating(rateId);
            
            if (!_ratingRepository.RatingExists(rateId))
                return NotFound(InternalStatusCodes.EntityNotExist);
            
            if (await _userManager.IsInRoleAsync(user!, UserRoles.User))
            {
                if (rating.UserId != userId)
                    return BadRequest(InternalStatusCodes.InvalidUser);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_ratingRepository.DeleteRating(rating))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }

        [Authorize]
        [HttpPost("rate/review/{reviewId}/reaction")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateReaction([FromRoute] int reviewId, [FromBody] ReactionDto? reactionCreate)
        {
            if (reactionCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound(InternalStatusCodes.EntityNotExist);

            var review = _reviewRepository.GetReview(reviewId);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var user = await _userManager.FindByIdAsync(userId);
            
            if (_reactionRepository.ReactionExists(reviewId, userId))
                return BadRequest(InternalStatusCodes.EntityExist);

            var reactionMap = _mapper.Map<Reaction>(reactionCreate);

            reactionMap.Review = review;
            reactionMap.User = user;
            
            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (!_reactionRepository.CreateReaction(reactionMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpPut("rate/review/{reviewId}/reaction")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateReaction(int reviewId, [FromBody] ReactionDto? updatedReaction)
        {
            if (updatedReaction == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound(InternalStatusCodes.EntityNotExist);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var reactionMap = _mapper.Map<Reaction>(updatedReaction);

            if (!_reactionRepository.UpdateReaction(reactionMap, reviewId, userId))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpDelete("rate/review/{reviewId}/reaction")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteReaction(int reviewId)
        {
            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound(InternalStatusCodes.EntityNotExist);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            if (!_reactionRepository.ReactionExists(reviewId, userId))
                return NotFound(InternalStatusCodes.EntityNotExist);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_reactionRepository.DeleteReaction(reviewId, userId))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }
    }
}
