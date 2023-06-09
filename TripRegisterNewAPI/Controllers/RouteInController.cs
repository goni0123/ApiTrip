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
    public class RouteInController : ControllerBase
    {
        private readonly IncomingInterface _incomingInterface;
        private readonly RouteInInterface _routeInInterface;
        private readonly IMapper _mapper;

        public RouteInController(IncomingInterface incomingInterface, RouteInInterface routeInInterface, IMapper mapper)
        {
            _incomingInterface = incomingInterface;
            _routeInInterface = routeInInterface;
            _mapper = mapper;
        }
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateRouteIn([FromQuery] int incomingId, [FromBody] RouteInDto routeCreate)
        {
            if (routeCreate == null)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lastRoute = new LastRoute();
            var routeMap = _mapper.Map<RouteIn>(routeCreate);

            var incoming = _incomingInterface.GetIncoming(incomingId);
            if (incoming == null)
            {
                ModelState.AddModelError("", "Invalid incomingId");
                return BadRequest(ModelState);
            }

            routeMap.Incoming = incoming;
            lastRoute.City = routeMap.City;
            lastRoute.Trailor = routeMap.Trailor;

            if (!_routeInInterface.CreateRouteIn(lastRoute, routeMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }
    }
}
