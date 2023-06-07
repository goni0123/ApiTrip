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
    public class TrailorsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public TrailorsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Trailors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trailor>>> Gettrailors()
        {
          if (_context.trailors == null)
          {
              return NotFound();
          }
            return await _context.trailors.ToListAsync();
        }

        // GET: api/Trailors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trailor>> GetTrailor(string id)
        {
          if (_context.trailors == null)
          {
              return NotFound();
          }
            var trailor = await _context.trailors.FindAsync(id);

            if (trailor == null)
            {
                return NotFound();
            }

            return trailor;
        }

        // PUT: api/Trailors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrailor(string id, Trailor trailor)
        {
            if (id != trailor.trailor)
            {
                return BadRequest();
            }

            _context.Entry(trailor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrailorExists(id))
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

        // POST: api/Trailors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Trailor>> PostTrailor(Trailor t)
        {
          if (_context.trailors == null)
          {
              return Problem("Entity set 'AppDBContext.trailors'  is null.");
          }
            _context.trailors.Add(t);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TrailorExists(t.trailor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTrailor", new { id = t.trailor }, t);
        }

        // DELETE: api/Trailors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrailor(string id)
        {
            if (_context.trailors == null)
            {
                return NotFound();
            }
            var trailor = await _context.trailors.FindAsync(id);
            if (trailor == null)
            {
                return NotFound();
            }

            _context.trailors.Remove(trailor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrailorExists(string id)
        {
            return (_context.trailors?.Any(e => e.trailor == id)).GetValueOrDefault();
        }
    }
}
