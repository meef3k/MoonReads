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
    public class PublisherController : Controller
    {
        private const string DefaultDescription = "Ten wydawca nie ma jeszcze opisu";
        private const string DefaultImageUrl = "https://cdn-icons-png.flaticon.com/512/10701/10701484.png";
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;

        public PublisherController(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Publisher>))]
        public IActionResult GetPublishers()
        {
            var publishers = _mapper.Map<List<PublisherDto>>(_publisherRepository.GetPublishers());

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

        [HttpGet("{publisherId}/Book")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        [ProducesResponseType(400)]
        public IActionResult GetBookByPublisher(int publisherId)
        {
            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            var books = _mapper.Map<List<BookDetailDto>>(_publisherRepository.GetBookByPublisher(publisherId));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(books);
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreatePublisher([FromBody] PublisherDto? publisherCreate)
        {
            if (publisherCreate == null)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            var publisher = _publisherRepository
                .GetPublishers()
                .FirstOrDefault(c => c.Name.Trim().ToUpper() == publisherCreate.Name.TrimEnd().ToUpper());

            if (publisher != null)
            {
                return StatusCode(422, InternalStatusCodes.EntityExist);
            }

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);
            
            if (publisherCreate.Description.IsNullOrEmpty())
            {
                publisherCreate.Description = DefaultDescription;
            }

            if (publisherCreate.ImageUrl.IsNullOrEmpty())
            {
                publisherCreate.ImageUrl = DefaultImageUrl;
            }

            var publisherMap = _mapper.Map<Publisher>(publisherCreate);

            if (!_publisherRepository.CreatePublisher(publisherMap))
            {
                return StatusCode(500, InternalStatusCodes.CreateError);
            }

            return NoContent();
        }

        [Authorize]
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

            return NoContent();
        }
    }
}
