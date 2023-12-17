using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private readonly IReviewRepository _reviewRepository;
        private readonly UserManager<User> _userManager;
        private readonly IReviewRatingRepository _reviewRatingRepository;

        public BookController(IBookRepository bookRepository,
            IPublisherRepository publisherRepository,
            IMapper mapper,
            IReviewRepository reviewRepository,
            UserManager<User> userManager,
            IReviewRatingRepository reviewRatingRepository)
		{
			_bookRepository = bookRepository;
            _publisherRepository = publisherRepository;
            _mapper = mapper;
            _reviewRepository = reviewRepository;
            _userManager = userManager;
            _reviewRatingRepository = reviewRatingRepository;
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
				return NotFound();

			var book = _mapper.Map<BookDetailDto>(_bookRepository.GetBookDetails(bookId));

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
        
        [HttpGet("{bookId}/review")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Review>))]
        public IActionResult GetReviews(int bookId)
        {
            var reviews = _mapper.Map<List<ReviewDto>>(_reviewRepository.GetReviews(bookId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(reviews);
        }
        
        [Authorize]
        [HttpPost("{bookId}/review")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateReview(int bookId, [FromBody] ReviewDto? reviewCreate)
        {
            if (reviewCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var book = _bookRepository.GetBook(bookId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var reviewMap = _mapper.Map<Review>(reviewCreate);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var user = await _userManager.FindByIdAsync(userId);
            
            reviewMap.Book = book;
            reviewMap.User = user;

            if (!_reviewRepository.CreateReview(reviewMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpPut("{bookId}/review/{reviewId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateReview(int bookId, int reviewId, [FromBody] ReviewDto? updatedReview)
        {
            if (updatedReview == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var reviewMap = _mapper.Map<Review>(updatedReview);
            
            var book = _bookRepository.GetBook(bookId);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var user = await _userManager.FindByIdAsync(userId);

            reviewMap.Id = reviewId;
            reviewMap.Book = book;
            reviewMap.User = user;

            if (!_reviewRepository.UpdateReview(reviewMap))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpDelete("{bookId}/review/{reviewId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public async Task<IActionResult> DeleteReview(int bookId, int reviewId)
        {
            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound();

            var review = _reviewRepository.GetReview(reviewId);
            
            var book = _bookRepository.GetBook(bookId);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var user = await _userManager.FindByIdAsync(userId);
            
            if (review.Book != book)
            {
                return StatusCode(422, InternalStatusCodes.CannotDeleteEntity);
            }
            
            if (review.User != user)
            {
                return StatusCode(422, InternalStatusCodes.CannotDeleteEntity);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_reviewRepository.DeleteReview(review))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpPost("bookId/review/{reviewId}/rating")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CreateReviewRating(int reviewId, [FromBody] ReviewRatingDto? reviewRatingCreate)
        {
            if (reviewRatingCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (!_reviewRepository.ReviewExists(reviewId))
            {
                return StatusCode(422, InternalStatusCodes.EntityNotExist);
            }
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var user = await _userManager.FindByIdAsync(userId);
            
            if (user == null)
            {
                return StatusCode(422, InternalStatusCodes.InvalidUser);
            }
            
            var reviewRatingMap = _mapper.Map<ReviewRating>(reviewRatingCreate);

            var review = _reviewRepository.GetReview(reviewId);
            
            reviewRatingMap.Review = review;
            reviewRatingMap.User = user;

            if (!_reviewRatingRepository.CreateReviewRating(reviewRatingMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpPut("bookId/review/{reviewId}/rating/{reviewRatingId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateReviewRating(int reviewId, int reviewRatingId, [FromBody] ReviewRatingDto? updatedReviewRating)
        {
            if (updatedReviewRating == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound();
            
            if (!_reviewRatingRepository.ReviewRatingExists(reviewRatingId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var user = await _userManager.FindByIdAsync(userId);
            
            if (user == null)
            {
                return StatusCode(422, InternalStatusCodes.InvalidUser);
            }

            var reviewRatingMap = _mapper.Map<ReviewRating>(updatedReviewRating);
            
            var review = _reviewRepository.GetReview(reviewId);
            
            reviewRatingMap.Id = reviewId;
            reviewRatingMap.Review = review;
            reviewRatingMap.User = user;

            if (!_reviewRatingRepository.UpdateReviewRating(reviewRatingMap))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }
        
        [Authorize]
        [HttpDelete("bookId/review/{reviewId}/rating/{reviewRatingId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public async Task<IActionResult> DeleteReviewRating(int reviewId, int reviewRatingId)
        {
            if (!_reviewRepository.ReviewExists(reviewId))
                return NotFound();
            
            var reviewRating = _reviewRatingRepository.GetReviewRating(reviewRatingId);

            var review = _reviewRepository.GetReview(reviewId);
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
            var user = await _userManager.FindByIdAsync(userId);
            
            if (reviewRating.Review != review)
            {
                return StatusCode(422, InternalStatusCodes.CannotDeleteEntity);
            }
            
            if (reviewRating.User != user)
            {
                return StatusCode(422, InternalStatusCodes.InvalidUser);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_reviewRatingRepository.DeleteReviewRating(reviewRating))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }
    }
}
