using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;
using MoonReads.Repository;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : Controller
    {
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
                return BadRequest(ModelState);

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
                return BadRequest(ModelState);

            return Ok(publisher);
        }

        [HttpGet("{publisherId}/Book")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        [ProducesResponseType(400)]
        public IActionResult GetBookByPublisher(int publisherId)
        {
            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            var books = _mapper.Map<List<BookDto>>(_publisherRepository.GetBookByPublisher(publisherId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(books);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreatePublisher([FromBody] PublisherDto publisherCreate)
        {
            if (publisherCreate == null)
                return BadRequest(ModelState);

            var publisher = _publisherRepository.GetPublishers()
                .Where(c => c.Name.Trim().ToUpper() == publisherCreate.Name.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (publisher != null)
            {
                ModelState.AddModelError("", "Publisher already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var publisherMap = _mapper.Map<Publisher>(publisherCreate);

            if (!_publisherRepository.CreatePublisher(publisherMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpPut("{publisherId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdatePublisher(int publisherId, [FromBody] PublisherDto updatedPublisher)
        {
            if (updatedPublisher == null)
                return BadRequest(ModelState);

            if (publisherId != updatedPublisher.Id)
                return BadRequest(ModelState);

            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var publisherMap = _mapper.Map<Publisher>(updatedPublisher);

            if (!_publisherRepository.UpdatePublisher(publisherMap))
            {
                ModelState.AddModelError("", "Something went wrong while updating");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{publisherId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeletePublisher(int publisherId)
        {
            if (!_publisherRepository.PublisherExists(publisherId))
                return NotFound();

            var publisher = _publisherRepository.GetPublisher(publisherId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_publisherRepository.DeletePublisher(publisher))
            {
                ModelState.AddModelError("", "Something went wrong while deleting");
            }

            return NoContent();
        }
    }
}
