using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookshelfController : Controller
{
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IBookRepository _bookRepository;
    private readonly IBookshelfRepository _bookshelfRepository;
    
    public BookshelfController(IMapper mapper,
        UserManager<User> userManager,
        IBookRepository bookRepository,
        IBookshelfRepository bookshelfRepository)
    {
        _mapper = mapper;
        _userManager = userManager;
        _bookRepository = bookRepository;
        _bookshelfRepository = bookshelfRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(PagedList<BookshelfHelperDto>))]
    public IActionResult GetBookshelf(
        string? searchTerm,
        [FromQuery] Dictionary<string, string>? filterTerms,
        string? sortColumn,
        string? sortOrder,
        int? page,
        int? pageSize)
    {
        var bookshelf = _mapper.Map<PagedList<BookshelfDetailDto>>(_bookshelfRepository.GetBookshelves(
            searchTerm,
            filterTerms,
            sortColumn,
            sortOrder,
            page,
            pageSize));
        
        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        return Ok(bookshelf);
    }
    
    [Authorize]
    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> CreateBookshelf([FromQuery][Required] int bookId, [FromBody] BookshelfDto? bookshelfCreate)
    {
        if (bookshelfCreate == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        if (!_bookRepository.BookExists(bookId))
            return NotFound(InternalStatusCodes.EntityNotExist);

        var book = _bookRepository.GetBook(bookId);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

        var user = await _userManager.FindByIdAsync(userId);

        if (_bookshelfRepository.BookshelfExists(book, user!))
            return BadRequest(InternalStatusCodes.EntityExist);

        var bookshelfMap = _mapper.Map<Bookshelf>(bookshelfCreate);

        bookshelfMap.User = user!;
        bookshelfMap.Book = book;
            
        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        var id = _bookshelfRepository.CreateBookshelf(bookshelfMap);

        return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
    }
    
    [Authorize]
    [HttpPut]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> UpdateBookshelf([FromQuery][Required] int bookId, [FromBody] BookshelfDto? updatedBookshelf)
    {
        var book = _bookRepository.GetBook(bookId);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
        var user = await _userManager.FindByIdAsync(userId);
            
        var bookshelf = _bookshelfRepository.GetBookshelf(book, user!);
            
        if (updatedBookshelf == null)
            return BadRequest(InternalStatusCodes.InvalidPayload);
            
        if (!_bookshelfRepository.BookshelfExists(book, user!))
            return NotFound(InternalStatusCodes.EntityNotExist);
            
        if (bookshelf!.User != user)
            return BadRequest(InternalStatusCodes.InvalidUser);

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        bookshelf.Status = updatedBookshelf.Status;

        if (!_bookshelfRepository.UpdateBookshelf(bookshelf))
        {
            return StatusCode(500, InternalStatusCodes.EditError);
        }

        return NoContent();
    }
        
    [Authorize]
    [HttpDelete]
    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> DeleteBookshelf([FromQuery][Required] int bookId)
    {
        var book = _bookRepository.GetBook(bookId);
            
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            
        var user = await _userManager.FindByIdAsync(userId);
            
        var bookshelf = _bookshelfRepository.GetBookshelf(book, user!);
            
        if (!_bookshelfRepository.BookshelfExists(book, user!))
            return NotFound(InternalStatusCodes.EntityNotExist);
            
        if (await _userManager.IsInRoleAsync(user!, UserRoles.User))
        {
            if (bookshelf!.User != user)
                return BadRequest(InternalStatusCodes.InvalidUser);
        }

        if (!ModelState.IsValid)
            return BadRequest(InternalStatusCodes.InvalidPayload);

        if (!_bookshelfRepository.DeleteBookshelf(bookshelf!))
        {
            return BadRequest(InternalStatusCodes.DeleteError);
        }

        return NoContent();
    }
}