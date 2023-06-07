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
    public class LoadingOrderInsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public LoadingOrderInsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/LoadingOrderIns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoadingOrderIn>>> GetloadingOrderIn()
        {
          if (_context.loadingOrderIn == null)
          {
              return NotFound();
          }
            return await _context.loadingOrderIn.ToListAsync();
        }

        // GET: api/LoadingOrderIns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoadingOrderIn>> GetLoadingOrderIn(int id)
        {
          if (_context.loadingOrderIn == null)
          {
              return NotFound();
          }
            var loadingOrderIn = await _context.loadingOrderIn.FindAsync(id);

            if (loadingOrderIn == null)
            {
                return NotFound();
            }

            return loadingOrderIn;
        }

        // PUT: api/LoadingOrderIns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoadingOrderIn(int id, LoadingOrderIn loadingOrderIn)
        {
            if (id != loadingOrderIn.LoadingOrderNumber)
            {
                return BadRequest();
            }

            _context.Entry(loadingOrderIn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoadingOrderInExists(id))
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

        // POST: api/LoadingOrderIns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoadingOrderIn>> PostLoadingOrderIn(LoadingOrderIn loadingOrderIn)
        {
          if (_context.loadingOrderIn == null)
          {
              return Problem("Entity set 'AppDBContext.loadingOrderIn'  is null.");
          }
            _context.loadingOrderIn.Add(loadingOrderIn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoadingOrderIn", new { id = loadingOrderIn.LoadingOrderNumber }, loadingOrderIn);
        }

        // DELETE: api/LoadingOrderIns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoadingOrderIn(int id)
        {
            if (_context.loadingOrderIn == null)
            {
                return NotFound();
            }
            var loadingOrderIn = await _context.loadingOrderIn.FindAsync(id);
            if (loadingOrderIn == null)
            {
                return NotFound();
            }

            _context.loadingOrderIn.Remove(loadingOrderIn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoadingOrderInExists(int id)
        {
            return (_context.loadingOrderIn?.Any(e => e.LoadingOrderNumber == id)).GetValueOrDefault();
        }
    }
}
