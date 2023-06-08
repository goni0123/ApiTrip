using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripRegisterNewAPI.Dto;
using TripRegisterNewAPI.Interfaces;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderOutController : ControllerBase
    {
        private readonly LoadingOrderOutInterface _loadingOrderOutInterface;
        private readonly IMapper _mapper;
        public OrderOutController(LoadingOrderOutInterface loadingOrderOutInterface,IMapper mapper)
        {
            _loadingOrderOutInterface = loadingOrderOutInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<LoadingOrderOutDto>))]
        public IActionResult GetOrders()
        {
            var orders = _mapper.Map<List<LoadingOrderOutDto>>(_loadingOrderOutInterface.Getorders());
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(orders);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200,Type=typeof(LoadingOrderOutDto))]
        public IActionResult GetOrder(int id) {
            if(!_loadingOrderOutInterface.OrderExits(id))
                return NotFound();
            var order = _mapper.Map<LoadingOrderOutDto>(_loadingOrderOutInterface.GetOrder(id));
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(order);
        }
    }
}
