using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailorController : ControllerBase
    {
        private readonly TrailorInterface _trailorInterface;
        private readonly IMapper _mapper;
        public TrailorController(TrailorInterface trailorInterface,IMapper mapper)
        {
            _mapper = mapper;
            _trailorInterface = trailorInterface;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Trailor>))]
        [ProducesResponseType(400)]
        public IActionResult GetTrailor(string id) 
        {
            if(!_trailorInterface.TrailorExists(id))
                return NotFound();
            var trailor=_trailorInterface.GetTrailor(id);
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(trailor);
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Trailor>))]
        public IActionResult GetTrailors()
        {
            var trailors = _trailorInterface.GetTrailors();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(trailors);
        }
    }
}
