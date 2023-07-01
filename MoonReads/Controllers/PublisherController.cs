using System;
using Microsoft.AspNetCore.Mvc;
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

        public PublisherController(IPublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Publisher>))]
        public IActionResult GetPublishers()
        {
            var publishers = _publisherRepository.GetPublishers();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(publishers);
        }
    }
}
