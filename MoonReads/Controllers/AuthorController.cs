using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    public class AuthorController : Controller
    {
        private const string DefaultDescription = "Ten autor nie ma jeszcze opisu";
        private const string DefaultImageUrl = "https://cdn-icons-png.flaticon.com/512/10701/10701484.png";
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AuthorDetailDto>))]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAuthors();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(authors);
        }

        [HttpGet("{authorId}")]
        [ProducesResponseType(200, Type = typeof(AuthorDetailDto))]
        [ProducesResponseType(400)]
        public IActionResult GetAuthor(int authorId)
        {
            if (!_authorRepository.AuthorExists(authorId))
                return NotFound();

            var author = _authorRepository.GetAuthorDetail(authorId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(author);
        }

        [HttpGet("{authorId}/Book")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        [ProducesResponseType(400)]
        public IActionResult GetBookByAuthor(int authorId)
        {
            if (!_authorRepository.AuthorExists(authorId))
                return NotFound();

            var books = _mapper.Map<List<BookDetailDto>>(_authorRepository.GetBookByAuthor(authorId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(books);
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateAuthor([FromBody] AuthorDto? authorCreate)
        {
            if (authorCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var author = _authorRepository
                .GetAuthors()
                .FirstOrDefault(c => c.Name.Trim().ToUpper() == authorCreate.Name.TrimEnd().ToUpper());

            if (author != null)
            {
                return StatusCode(422, InternalStatusCodes.EntityExist);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (authorCreate.Description.IsNullOrEmpty())
            {
                authorCreate.Description = DefaultDescription;
            }

            if (authorCreate.ImageUrl.IsNullOrEmpty())
            {
                authorCreate.ImageUrl = DefaultImageUrl;
            }

            var authorMap = _mapper.Map<Author>(authorCreate);

            if (!_authorRepository.CreateAuthor(authorMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }

        [Authorize]
        [HttpPut("{authorId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateAuthor(int authorId, [FromBody] AuthorDto? updatedAuthor)
        {
            if (updatedAuthor == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (authorId != updatedAuthor.Id)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_authorRepository.AuthorExists(authorId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var authorMap = _mapper.Map<Author>(updatedAuthor);

            if (!_authorRepository.UpdateAuthor(authorMap))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpDelete("{authorId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public IActionResult DeleteAuthor(int authorId)
        {
            if (!_authorRepository.AuthorExists(authorId))
                return NotFound();

            var author = _authorRepository.GetAuthor(authorId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (_authorRepository.HasBooks(author))
                return Conflict(InternalStatusCodes.CannotDeleteEntity);

            if (!_authorRepository.DeleteAuthor(author))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }
    }
}
