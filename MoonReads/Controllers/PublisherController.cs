using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MoonReads.Dto.Publisher;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : Controller
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;
        private readonly ICacheRepository _cacheRepository;

        public PublisherController(IPublisherRepository publisherRepository, IMapper mapper, ICacheRepository cacheRepository)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
            _cacheRepository = cacheRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(PagedList<PublisherDto>))]
        public IActionResult GetPublishers(
            string? searchTerm,
            string? sortColumn,
            string? sortOrder,
            int? page,
            int? pageSize)
        {
            var path = HttpContext.Request.GetEncodedUrl();
            
            var cacheData = _cacheRepository.GetData<PagedList<PublisherDto>>(path);

            if (cacheData is { Items.Count: > 0 })
                return Ok(cacheData);
            
            var publishers = _mapper.Map<PagedList<PublisherDto>>(_publisherRepository.GetPublishers(
                searchTerm,
                sortColumn,
                sortOrder,
                page,
                pageSize));
            
            _cacheRepository.SetData(path, publishers, DateTimeOffset.Now.AddMinutes(Defaults.CacheExpiryTime));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(publishers);
        }

        [HttpGet("{publisherId}")]
        [ProducesResponseType(200, Type = typeof(Publisher))]
        [ProducesResponseType(400)]
        public IActionResult GetPublisher(int publisherId)
        {
            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            var publisher = _mapper.Map<PublisherDto>(_publisherRepository.GetPublisher(publisherId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(publisher);
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreatePublisher([FromBody] PublisherDto? publisherCreate)
        {
            if (publisherCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (_publisherRepository.PublisherExists(publisherCreate.Name))
            {
                return StatusCode(422, InternalStatusCodes.EntityExist);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (publisherCreate.Description.IsNullOrEmpty())
            {
                publisherCreate.Description = Defaults.PublisherDescription;
            }

            if (publisherCreate.ImageUrl.IsNullOrEmpty())
            {
                publisherCreate.ImageUrl = Defaults.PublisherPhoto;
            }

            var publisherMap = _mapper.Map<Publisher>(publisherCreate);

            var id = _publisherRepository.CreatePublisher(publisherMap);
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

            return id == 0 ? StatusCode(500, InternalStatusCodes.CreateError) : Created(string.Empty, new { id });
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpPut("{publisherId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdatePublisher(int publisherId, [FromBody] PublisherDto? updatedPublisher)
        {
            if (updatedPublisher == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (publisherId != updatedPublisher.Id)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var publisherMap = _mapper.Map<Publisher>(updatedPublisher);

            if (!_publisherRepository.UpdatePublisher(publisherMap))
            {
                return StatusCode(500, InternalStatusCodes.EditError);
            }
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

            return NoContent();
        }

        [Authorize(Roles = $"{UserRoles.Admin},{UserRoles.Moderator}")]
        [HttpDelete("{publisherId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public IActionResult DeletePublisher(int publisherId)
        {
            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            var publisher = _publisherRepository.GetPublisher(publisherId);

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (_publisherRepository.HasBooks(publisher))
                return Conflict(InternalStatusCodes.CannotDeleteEntity);

            if (!_publisherRepository.DeletePublisher(publisher))
            {
                return BadRequest(InternalStatusCodes.DeleteError);
            }
            
            _cacheRepository.RemoveData(ControllerContext.ActionDescriptor.ControllerName);

            return NoContent();
        }
    }
}
