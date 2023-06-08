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
    public class OutgoingController : ControllerBase
    {
        private readonly OutgoingInterface _outgoingInterface;
        private readonly IMapper _mapper;

        public OutgoingController(OutgoingInterface outgoingInterface, IMapper mapper)
        {
            _outgoingInterface = outgoingInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Outgoing>))]
        public IActionResult GetOutgoings()
        {
            var outgoings = _mapper.Map<List<OutgoingDto>>(_outgoingInterface.GetOutgoings());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(outgoings);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Outgoing))]
        [ProducesResponseType(400)]
        public IActionResult GetOutgoing(int id)
        {
            if (!_outgoingInterface.OutgoingExists(id))
                return NotFound();

            var outgoing = _mapper.Map<OutgoingDto>(_outgoingInterface.GetOutgoing(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(outgoing);
        }
        [HttpGet("/routeouts/{outgoingid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<RouteOutDto>))]
        public IActionResult GetRouteById(int outgoingid)
        {
            var routes = _outgoingInterface.GetRouteById(outgoingid);

            if (routes == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var routeDtos = _mapper.Map<List<RouteOutDto>>(routes);
            return Ok(routeDtos);
        }
        [HttpGet("/lodaingouts/{outgoingid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<LoadingCompanyOutDto>))]
        public IActionResult GetLoadingById(int outgoingid)
        {
            var loading = _outgoingInterface.GetLoadingById(outgoingid);

            if (loading == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var routeDtos = _mapper.Map<List<LoadingCompanyOutDto>>(loading);
            return Ok(routeDtos);
        }
    }
}
