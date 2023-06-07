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
    public class TrucksController : ControllerBase
    {
        private readonly AppDBContext _context;

        public TrucksController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Trucks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Truck>>> Gettrucks()
        {
          if (_context.trucks == null)
          {
              return NotFound();
          }
            return await _context.trucks.ToListAsync();
        }

        // GET: api/Trucks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Truck>> GetTruck(string id)
        {
          if (_context.trucks == null)
          {
              return NotFound();
          }
            var truck = await _context.trucks.FindAsync(id);

            if (truck == null)
            {
                return NotFound();
            }

            return truck;
        }

        // PUT: api/Trucks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTruck(string id, Truck truck)
        {
            if (id != truck.truck)
            {
                return BadRequest();
            }

            _context.Entry(truck).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TruckExists(id))
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

        // POST: api/Trucks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Truck>> PostTruck(Truck truck)
        {
          if (_context.trucks == null)
          {
              return Problem("Entity set 'AppDBContext.trucks'  is null.");
          }
            _context.trucks.Add(truck);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TruckExists(truck.truck))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTruck", new { id = truck.truck }, truck);
        }

        // DELETE: api/Trucks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTruck(string id)
        {
            if (_context.trucks == null)
            {
                return NotFound();
            }
            var truck = await _context.trucks.FindAsync(id);
            if (truck == null)
            {
                return NotFound();
            }

            _context.trucks.Remove(truck);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TruckExists(string id)
        {
            return (_context.trucks?.Any(e => e.truck == id)).GetValueOrDefault();
        }
    }
}
