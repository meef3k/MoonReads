using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Dto.Category;
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
        [ProducesResponseType(200, Type = typeof(PagedList<CategoryDto>))]
        public IActionResult GetCategories(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            var categories = _mapper.Map<PagedList<CategoryDto>>(_categoryRepository.GetCategories(
                searchTerm,
                sortColumn,
                sortOrder,
                page,
                pageSize));

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

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateCategory([FromBody] CategoryDto? categoryCreate)
        {
            if (categoryCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (_categoryRepository.CategoryExists(categoryCreate.Name))
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
