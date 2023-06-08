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
    public class CostController : ControllerBase
    {
        private readonly CostInterface _costInterface;
        private readonly IMapper _mapper;
        public CostController(CostInterface costInterface,IMapper mapper)
        {
            _costInterface = costInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<Cost>))]
        public IActionResult GetCosts() {
            var costs = _mapper.Map<List<CostDto>>(_costInterface.GetCosts());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return Ok(costs);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Incoming))]
        [ProducesResponseType(400)]
        public IActionResult GetCost(int id)
        {
            if (!_costInterface.CostExists(id))
                return NotFound();
            var cost= _mapper.Map<CostDto>(_costInterface.GetCost(id));

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(cost);
        }
    }
}
