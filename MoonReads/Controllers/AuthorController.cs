using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Dto.Author;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        private readonly ICacheRepository _cacheRepository;

        public AuthorController(IAuthorRepository authorRepository, IMapper mapper, ICacheRepository cacheRepository)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
            _cacheRepository = cacheRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(PagedList<AuthorDetailDto>))]
        public IActionResult GetAuthors(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            var path = HttpContext.Request.GetEncodedUrl();
            
            var cacheData = _cacheRepository.GetData<PagedList<AuthorDetailDto>>(path);

            if (cacheData is { Items.Count: > 0 })
                return Ok(cacheData);
            
            var authors = _authorRepository.GetAuthors(
                searchTerm,
                sortColumn,
                sortOrder,
                page,
                pageSize);
            
            _cacheRepository.SetData(path, authors, DateTimeOffset.Now.AddMinutes(Defaults.CacheExpiryTime));

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

        [Authorize]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateAuthor([FromBody] AuthorDto? authorCreate)
        {
            if (authorCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (_authorRepository.AuthorExists(authorCreate.Name))
            {
                return StatusCode(422, InternalStatusCodes.EntityExist);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (authorCreate.Description.IsNullOrEmpty())
            {
                authorCreate.Description = Defaults.AuthorDescription;
            }

            if (authorCreate.ImageUrl.IsNullOrEmpty())
            {
                authorCreate.ImageUrl = Defaults.AuthorPhoto;
            }

            var authorMap = _mapper.Map<Author>(authorCreate);
            
            var id = _authorRepository.CreateAuthor(authorMap);
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

            return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
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
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

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
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

            return NoContent();
        }
    }
}
