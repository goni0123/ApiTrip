using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CostsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Costs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cost>>> Getcosts()
        {
          if (_context.costs == null)
          {
              return NotFound();
          }
            return await _context.costs.ToListAsync();
        }

        // GET: api/Costs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cost>> GetCost(int id)
        {
          if (_context.costs == null)
          {
              return NotFound();
          }
            var cost = await _context.costs.FindAsync(id);

            if (cost == null)
            {
                return NotFound();
            }

            return cost;
        }

        // PUT: api/Costs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCost(int id, Cost cost)
        {
            if (id != cost.Nalog)
            {
                return BadRequest();
            }

            _context.Entry(cost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Costs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cost>> PostCost(Cost cost)
        {
          if (_context.costs == null)
          {
              return Problem("Entity set 'AppDBContext.costs'  is null.");
          }
            _context.costs.Add(cost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCost", new { id = cost.Nalog }, cost);
        }

        // DELETE: api/Costs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCost(int id)
        {
            if (_context.costs == null)
            {
                return NotFound();
            }
            var cost = await _context.costs.FindAsync(id);
            if (cost == null)
            {
                return NotFound();
            }

            _context.costs.Remove(cost);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CostExists(int id)
        {
            return (_context.costs?.Any(e => e.Nalog == id)).GetValueOrDefault();
        }
    }
}
