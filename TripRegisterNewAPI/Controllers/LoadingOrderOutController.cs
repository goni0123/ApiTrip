using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadingOrderOutController : ControllerBase
    {
        private readonly AppDBContext _context;
        public LoadingOrderOutController(AppDBContext context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<LoadingOrderOut>> Get()
            => await _context.loadingOrderOut.ToListAsync();

        [HttpGet("OrderNumber")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoadingOrderOut))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int OrderNumber)
        {
            var Loading = await _context.loadingOrderOut.FindAsync(OrderNumber);
            return Loading == null ? NotFound() : Ok(Loading);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(LoadingOrderOut Loading)
        {
            await _context.loadingOrderOut.AddAsync(Loading);
            await _context.Database.OpenConnectionAsync(); // Open the database connection
            try
            {
                await _context.Database.ExecuteSqlInterpolatedAsync($"SET IDENTITY_INSERT loadingOrderOut ON;");
                await _context.SaveChangesAsync();
                await _context.Database.ExecuteSqlInterpolatedAsync($"SET IDENTITY_INSERT loadingOrderOut OFF;");
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
        public async Task<IActionResult> Update(int id, LoadingOrderOut Loading)
        {
            if (id != Loading.LoadingOrderNumber) return BadRequest();
            _context.Entry(Loading).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            var loadingToDelete = await _context.loadingOrderOut.FindAsync(id);
            if (loadingToDelete == null) return NotFound();

            _context.loadingOrderOut.Remove(loadingToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
