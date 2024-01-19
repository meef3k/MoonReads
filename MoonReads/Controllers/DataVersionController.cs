using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoonReads.Dto;
using MoonReads.Dto.DataVersion;
using MoonReads.Helper;
using MoonReads.Interfaces;
using MoonReads.Models;

namespace MoonReads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataVersionController : Controller
    {
        private readonly IDataVersionRepository _dataVersionRepository;
        private readonly IMapper _mapper;

        public DataVersionController(IDataVersionRepository dataVersionRepository, IMapper mapper)
        {
            _dataVersionRepository = dataVersionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DataVersion>))]
        public IActionResult GetDataVersions()
        {
            var publishers = _mapper.Map<List<DataVersionDto>>(_dataVersionRepository.GetDataVersions());

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(publishers);
        }

        [HttpGet("{dataVersionTable}")]
        [ProducesResponseType(200, Type = typeof(DataVersion))]
        [ProducesResponseType(400)]
        public IActionResult GetPublisher(string dataVersionTable)
        {
            if (!_dataVersionRepository.DataVersionExists(dataVersionTable))
                return NotFound();

            var dataVersion = _mapper.Map<DataVersionDto>(_dataVersionRepository.GetDataVersion(dataVersionTable));

            if (!ModelState.IsValid)
                return BadRequest(InternalStatusCodes.InvalidPayload);

            return Ok(dataVersion);
        }
    }
}
