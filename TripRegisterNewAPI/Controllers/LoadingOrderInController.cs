using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadingOrderInController : ControllerBase
    {
        private readonly AppDBContext _context;
        public LoadingOrderInController(AppDBContext context)=> _context=context;
        [HttpGet]
        public async Task<IEnumerable<LoadingOrderIn>> Get()
            => await _context.loadingOrderIn.ToListAsync();
        [HttpGet("OrderNumber")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoadingOrderIn))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int OrderNumber)
        {
            var Loading=await _context.loadingOrderIn.FindAsync(OrderNumber);
            return Loading==null ? NotFound() : Ok(Loading);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(LoadingOrderIn Loading)
        {
            await _context.loadingOrderIn.AddAsync(Loading);
            await _context.Database.OpenConnectionAsync(); // Open the database connection
            try
            {
                await _context.Database.ExecuteSqlInterpolatedAsync($"SET IDENTITY_INSERT loadingOrderIn ON;");
                await _context.SaveChangesAsync();
                await _context.Database.ExecuteSqlInterpolatedAsync($"SET IDENTITY_INSERT loadingOrderIn OFF;");
            }
            finally
            {
                await _context.Database.CloseConnectionAsync(); // Close the database connection
            }
            return CreatedAtAction(nameof(GetById), new { id = Loading.LoadingOrderNumber }, Loading);

        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id,LoadingOrderIn Loading)
        {
            if(id != Loading.LoadingOrderNumber) return BadRequest();
            _context.Entry(Loading).State= EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            var loadingToDelete=await _context.loadingOrderIn.FindAsync(id);
            if(loadingToDelete == null) return NotFound();

            _context.loadingOrderIn.Remove(loadingToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
