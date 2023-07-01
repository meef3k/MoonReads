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
    }
}
