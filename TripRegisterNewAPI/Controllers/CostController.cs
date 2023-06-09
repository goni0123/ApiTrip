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
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateCost([FromBody]CostDto costCreate)
        {
            if(costCreate == null)
                return BadRequest(ModelState);
            var costs = _costInterface.GetCosts()
                .Where(c=>c.Nalog== costCreate.Nalog)
                .FirstOrDefault();
            if (costs != null)
            {
                ModelState.AddModelError("", "Cost exists");
                return StatusCode(442, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var costMap = _mapper.Map<Cost>(costCreate);

            if (!_costInterface.CreateCost(costMap))
            {
                ModelState.AddModelError("", "Somthing went wrong while saving");
                return StatusCode(500,ModelState);
            }

            return Ok("Saved Successfully");
        }
    }
}
