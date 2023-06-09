using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripRegisterNewAPI.Dto;
using TripRegisterNewAPI.Interfaces;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeekController : ControllerBase
    {
        private readonly WeekInterface _weekInterface;
        private readonly IMapper _mapper;
        public WeekController(WeekInterface weekInterface,IMapper mapper)
        {
            _weekInterface = weekInterface;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200,Type =typeof(IEnumerable<WeekDto>))]
        public IActionResult GetWeeks() 
        {
            var weeks = _mapper.Map<List<WeekDto>>(_weekInterface.GetWeeks());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(weeks);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(200,Type= typeof(IEnumerable<WeekDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetWeek(int id)
        {
            if (!_weekInterface.WeekExists(id))
                return NotFound();
            var week = _mapper.Map<WeekDto>(_weekInterface.GetWeek(id));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return  Ok(week);
        }
        [HttpGet("/inlandweek/{inlandid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(List<Inland_WeekDto>))]
        public IActionResult GetRouteById(int inlandid)
        {
            var inlands = _weekInterface.GetInlandById(inlandid);

            if (inlands == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var routeDtos = _mapper.Map<List<Inland_WeekDto>>(inlands);
            return Ok(routeDtos);
        }
        [HttpGet("/weekmore/{weekid}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200,Type=typeof(IEnumerable<Inland_Week_MoreDto>))]
        public IActionResult GetWeekMores(int weekid)
        {
            if(!_weekInterface.WeekExists(weekid))
                return NotFound();
            var mores= _weekInterface.GetWeekMores(weekid);
            if (mores == null)
                return NotFound();

            var moresDto=_mapper.Map<List<Inland_Week_MoreDto>>(mores);
            return Ok(moresDto);
        }
    }
}
