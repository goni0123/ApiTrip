using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripRegisterNewAPI.Dto;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InlandController : ControllerBase
    {
        private readonly InlandInterface _inland;
        private readonly IMapper _mapper;
        public InlandController(InlandInterface inland,IMapper mapper)
        {
            _inland = inland;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<Inland_driving>))]
        public IActionResult GetInlands()
        {
            var inlands = _mapper.Map<List<Inland_driving>>(_inland.GetInlands());

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(inlands);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Inland_driving>))]
        [ProducesResponseType(400)]
        public IActionResult GetInlands(int id)
        {
            if (!_inland.InlandExists(id))
                return NotFound();

            var inland = _mapper.Map<Inland_driving>(_inland.GetInland(id));
            if(!ModelState.IsValid)
                return NotFound();
            return Ok(inland);
        }
        [HttpGet("/mores/{inlandid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<InlandMoreDto>))]
        public IActionResult GetRouteById(int inlandid)
        {
            var mores = _inland.GetInlandMoreById(inlandid);

            if (mores == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var moresDtos = _mapper.Map<ICollection<InlandMoreDto>>(mores);
            return Ok(moresDtos);
        }
    }
}
