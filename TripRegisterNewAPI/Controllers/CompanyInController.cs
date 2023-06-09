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
    public class CompanyInController : ControllerBase
    {
        private readonly IncomingInterface _incomingInterface;
        private readonly CompanyInInterface _companyInInterface;
        private readonly IMapper _mapper;

        public CompanyInController(IncomingInterface incomingInterface,CompanyInInterface companyInInterface, IMapper mapper)
        {
            _incomingInterface = incomingInterface;
            _companyInInterface = companyInInterface;
            _mapper = mapper;
        }
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateOwner([FromQuery] int incomingId, [FromBody] LoadingCompanyInDto companyCreate)
        {
            if (companyCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var companyMap = _mapper.Map<LoadingCompanyIn>(companyCreate);

            companyMap.Incoming = _incomingInterface.GetIncoming(incomingId);

            if (!_companyInInterface.CreateCompanyIn(companyMap))
            {
                ModelState.AddModelError("", "Something went wrong while savin");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }
    }
}
