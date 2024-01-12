using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Dto.Author;
using MoonReads.Dto.Book;
using MoonReads.Helper;
using MoonReads.Interfaces;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelationController : Controller
    {
        private readonly IAuthorCategoryRepository _authorCategoryRepository;
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly IBookCategoryRepository _bookCategoryRepository;
        private readonly IMapper _mapper;

        public RelationController(IAuthorCategoryRepository authorCategoryRepository,
            IBookAuthorRepository bookAuthorRepository,
            IBookCategoryRepository bookCategoryRepository,
            IMapper mapper)
        {
            _authorCategoryRepository = authorCategoryRepository;
            _bookAuthorRepository = bookAuthorRepository;
            _bookCategoryRepository = bookCategoryRepository;
            _mapper = mapper;
        }

        [HttpGet("authorCategory")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AuthorCategoryDto>))]
        public IActionResult GetAuthorsCategories()
        {
            var authorsCategories = _mapper.Map<List<AuthorCategoryDto>>(_authorCategoryRepository.GetAuthorsCategories());

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(authorsCategories);
        }
        
        [HttpGet("bookAuthor")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BookAuthorDto>))]
        public IActionResult GetBooksAuthors()
        {
            var booksAuthors = _mapper.Map<List<BookAuthorDto>>(_bookAuthorRepository.GetBooksAuthors());

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(booksAuthors);
        }
        
        [HttpGet("bookCategory")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<BookCategoryDto>))]
        public IActionResult GetPublishers()
        {
            var booksCategories = _mapper.Map<List<BookCategoryDto>>(_bookCategoryRepository.GetBooksCategories());

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(booksCategories);
        }
    }
}