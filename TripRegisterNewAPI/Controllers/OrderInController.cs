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
    public class OrderInController : ControllerBase
    {
        private readonly LoadingOrderInInterface _loadingOrderInInterface;
        private readonly IMapper _mapper;
        public OrderInController(LoadingOrderInInterface loadingOrderInInterface,IMapper mapper)
        {
            _loadingOrderInInterface = loadingOrderInInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<LoadingOrderIn>))]
        public IActionResult GetOrders()
        {
            var costs = _mapper.Map<List<LoadingOrderInDto>>(_loadingOrderInInterface.GetOrders());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(costs);
        }
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            if (!_loadingOrderInInterface.OrderExists(id))
                return NotFound();
            var cost = _mapper.Map<LoadingOrderInDto>(_loadingOrderInInterface.GetOrder(id));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(cost);
        }
    }
}
