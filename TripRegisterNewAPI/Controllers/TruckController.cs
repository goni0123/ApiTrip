using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripRegisterNewAPI.Interfaces;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private readonly TruckInterface _truckInterface;
        private readonly IMapper _mapper;
        public TruckController(TruckInterface truckInterface,IMapper mapper)
        {
            _truckInterface = truckInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type =typeof(IEnumerable<Truck>))]
        public IActionResult GetTrucks()
        {
            var trucks = _truckInterface.GetTrucks();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(trucks);
        }
        [HttpGet("{truckid}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Truck>))]
        [ProducesResponseType(400)]
        public IActionResult GetTruck(string  truckId)
        {

            var truck =_truckInterface.GetTruck(truckId);
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(truck);
        }
    }
}
