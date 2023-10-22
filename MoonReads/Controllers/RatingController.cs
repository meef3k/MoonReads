using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : Controller
	{
        private readonly IRatingRepository _ratingRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public RatingController(IRatingRepository ratingRepository,
            IBookRepository bookRepository,
            IMapper mapper)
        {
            _ratingRepository = ratingRepository;
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateRating([FromQuery] int bookId, [FromBody] RatingDto? ratingCreate)
        {
            if (ratingCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Rating ratingMap = _mapper.Map<Rating>(ratingCreate);

            ratingMap.Book = _bookRepository.GetBook(bookId);

            if (!_ratingRepository.CreateRating(ratingMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }
    }
}

