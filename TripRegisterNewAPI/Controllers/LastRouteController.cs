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
    public class LastRouteController : ControllerBase
    {
        private readonly LastRouteInterface _lastRouteInterface;
        private readonly IMapper _mapper;
        public LastRouteController(LastRouteInterface lastRouteInterface, IMapper mapper)
        {
            _lastRouteInterface = lastRouteInterface;
            _mapper = mapper;
        }
        [HttpGet("{trailor}")]
        [ProducesResponseType(200,Type =typeof(IEnumerable<LastRoute>))]
        [ProducesResponseType(400)]
        public IActionResult GetRoute(string trailor) {
            if (!_lastRouteInterface.LastExists(trailor))
                return NotFound();

            var route=_mapper.Map<LastRouteDto>(_lastRouteInterface.GetRoute(trailor));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(route);
        }
    }
}
