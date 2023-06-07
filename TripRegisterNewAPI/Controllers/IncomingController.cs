using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomingController : ControllerBase
    {
        private readonly IncomingInterface _incomingInterface;
        public IncomingController(IncomingInterface incomingInterface)
        {
            _incomingInterface = incomingInterface;
        }
        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<Incoming>))]
        public IActionResult GetIncoming()
        {
            var incomings=_incomingInterface.GetIncoming();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(incomings);
        }
    }
}
