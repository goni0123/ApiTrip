using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using TripRegisterNewAPI.Dto;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomingController : ControllerBase
    {
        private readonly IncomingInterface _incomingInterface;
        private readonly IMapper _mapper;

        public IncomingController(IncomingInterface incomingInterface,IMapper mapper)
        {
            _incomingInterface = incomingInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Incoming>))]
        public IActionResult GetIncomings()
        {
            var incomings=_mapper.Map<List<IncomingDto>>(_incomingInterface.GetIncomings());
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(incomings);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200,Type=typeof(Incoming))]
        [ProducesResponseType(400)]
        public IActionResult GetIncoming(int id)
        {
            if(!_incomingInterface.IncomingExists(id))
                return NotFound();

            var incoming= _mapper.Map<IncomingDto>(_incomingInterface.GetIncoming(id));  
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(incoming);
        }
        [HttpGet("/routeins/{incomingid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<RouteInDto>))]
        public IActionResult GetRouteById(int incomingid)
        {
            var routes = _incomingInterface.GetRouteById(incomingid);

            if (routes == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var routeDtos = _mapper.Map<List<RouteInDto>>(routes);
            return Ok(routeDtos);
        }
        [HttpGet("/lodaingins/{incomingid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<LoadingCompanyInDto>))]
        public IActionResult GetLoadingById(int incomingid)
        {
            var loading = _incomingInterface.GetLoadingById(incomingid);

            if (loading == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var routeDtos = _mapper.Map<List<LoadingCompanyInDto>>(loading);
            return Ok(routeDtos);
        }
    }
}
