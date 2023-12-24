using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategories()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(400)]
        public IActionResult GetCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            var category = _mapper.Map<CategoryDto>(_categoryRepository.GetCategory(categoryId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(category);
        }

        [HttpGet("{categoryId}/Book")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        [ProducesResponseType(400)]
        public IActionResult GetBookByCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            var books = _mapper.Map<List<BookDetailDto>>(_categoryRepository.GetBookByCategory(categoryId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(books);
        }

        [HttpGet("{categoryId}/Author")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Author>))]
        [ProducesResponseType(400)]
        public IActionResult GetAuthorByCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            var authors = _mapper.Map<List<AuthorDto>>(_categoryRepository.GetAuthorByCategory(categoryId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(authors);
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateCategory([FromBody] CategoryDto? categoryCreate)
        {
            if (categoryCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var category = _categoryRepository
                .GetCategories()
                .FirstOrDefault(c => c.Name.Trim().ToUpper() == categoryCreate.Name.TrimEnd().ToUpper());

            if (category != null)
            {
                return StatusCode(422, InternalStatusCodes.EntityExist);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var categoryMap = _mapper.Map<Category>(categoryCreate);

            var id = _categoryRepository.CreateCategory(categoryMap);

            return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpPut("{categoryId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateCategory(int categoryId, [FromBody] CategoryDto? updatedCategory)
        {
            if (updatedCategory == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (categoryId != updatedCategory.Id)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var categoryMap = _mapper.Map<Category>(updatedCategory);

            if (!_categoryRepository.UpdateCategory(categoryMap))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }

            return NoContent();
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpDelete("{categoryId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public IActionResult DeleteCategory(int categoryId)
        {
            if (!_categoryRepository.CategoryExists(categoryId))
                return NotFound();

            var category = _categoryRepository.GetCategory(categoryId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (_categoryRepository.HasBooks(category))
                return Conflict(InternalStatusCodes.CannotDeleteEntity);
            
            if (_categoryRepository.HasAuthors(category))
                return Conflict(InternalStatusCodes.CannotDeleteEntity);

            if (!_categoryRepository.DeleteCategory(category))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }

            return NoContent();
        }
    }
}
