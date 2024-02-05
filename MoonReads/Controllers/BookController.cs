using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Dto.Book;
using MoonReads.Dto.Bookshelf;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IBookRepository _bookRepository;
    private readonly IPublisherRepository _publisherRepository;
    private readonly IBookshelfRepository _bookshelfRepository;
    private readonly IRatingRepository _ratingRepository;
    private readonly IReactionRepository _reactionRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ICacheRepository _cacheRepository;

    public BookController(IMapper mapper,
        UserManager<User> userManager,
        IBookRepository bookRepository,
        IPublisherRepository publisherRepository,
        IBookshelfRepository bookshelfRepository,
        IRatingRepository ratingRepository,
        IReactionRepository reactionRepository,
        IHttpContextAccessor httpContextAccessor,
        ICacheRepository cacheRepository)
    {
        _mapper = mapper;
        _userManager = userManager;
        _bookRepository = bookRepository;
        _publisherRepository = publisherRepository;
        _bookshelfRepository = bookshelfRepository;
        _ratingRepository = ratingRepository;
        _reactionRepository = reactionRepository;
        _httpContextAccessor = httpContextAccessor;
        _cacheRepository = cacheRepository;
    }

    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(PagedList<BookDetailDto>))]
    public IActionResult GetBooks(
        bool pending,
        string searchTerm,
        [FromQuery] Dictionary<string, string[]>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        
        var path = HttpContext.Request.GetEncodedUrl();
            
        var cacheData = _cacheRepository.GetData<PagedList<BookDetailDto>>(path);

        if (cacheData is { Items.Count: > 0 })
            return Ok(cacheData);
        
        var books = _bookRepository.GetBooks(
            pending,
            searchTerm,
            filterTerms,
            sortColumn,
            sortOrder,
            page,
            pageSize,
            userId);
        
        _cacheRepository.SetData(path, books, DateTimeOffset.Now.AddMinutes(Defaults.CacheExpiryTime));

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        return Ok(books);
    }
       
    [AllowAnonymous]
    [HttpGet("{bookId}")]
    [ProducesResponseType(200, Type = typeof(BookDetailDto))]
    [ProducesResponseType(400)]
    public IActionResult GetBook(int bookId)
    {
        if (!_bookRepository.BookExists(bookId))
            return NotFound(InternalStatusCodes.EntityNotExist);
        
        var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

        var book = _mapper.Map<BookDetailDto>(_bookRepository.GetBookDetails(bookId, userId));

        if (book == null)
            return Unauthorized();

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        return Ok(book);
    }
    
    [HttpGet("{bookId}/user")]
    [ProducesResponseType(200, Type = typeof(BookUserDetailDto))]
    public async Task<IActionResult> GetUserBookshelf(int bookId)
    {
        if (!_bookRepository.BookExists(bookId))
            return NotFound(InternalStatusCodes.EntityNotExist);
            
        var book = _bookRepository.GetBook(bookId);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
        var user = await _userManager.FindByIdAsync(userId);
            
        var bookshelf = _bookshelfRepository.GetBookshelf(book, user!);

        var bookshelfMap = _mapper.Map<BookshelfShortDto>(bookshelf);
        
        var rating = _ratingRepository.GetUserRating(bookId, userId);
        
        var reaction = _reactionRepository.GetBookReactions(bookId, user!);

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        var bookUserDetail = new BookUserDetailDto
        {
            Bookshelf = bookshelfMap,
            Rating = rating,
            Reactions = reaction
        };

        return Ok(bookUserDetail);
    }
        
    [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
    [HttpPut("{bookId}/accept")]
    [ProducesResponseType(200)]
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
        
        _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

        return NoContent();
    }
    
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public IActionResult CreateBook([FromQuery] int publisherId, [FromQuery] int[] authorsIds, [FromQuery] int[] categoriesIds, [FromBody] BookDto? bookCreate)
    {
        if (bookCreate == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        if (_bookRepository.BookExists(bookCreate.Title))
        {
            return StatusCode(422, InternalStatusCodes.EntityExist);
        }

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        if (bookCreate.Description.IsNullOrEmpty())
        {
            bookCreate.Description = Defaults.BookDescription;
        }

        if (bookCreate.ImageUrl.IsNullOrEmpty())
        {
            bookCreate.ImageUrl = Defaults.BookPhoto;
        }

        var bookMap = _mapper.Map<Book>(bookCreate);
            
        bookMap.Pending = User.IsInRole(UserRoles.User);

        bookMap.Publisher = _publisherRepository.GetPublisher(publisherId);
            
        var id = _bookRepository.CreateBook(authorsIds, categoriesIds, bookMap);
        
        _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

        return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
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
        
        _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

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
        
        _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

        return NoContent();
    }
}