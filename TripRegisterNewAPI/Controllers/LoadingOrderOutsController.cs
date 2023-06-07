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
    public class LoadingOrderOutsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public LoadingOrderOutsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/LoadingOrderOuts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoadingOrderOut>>> GetloadingOrderOut()
        {
          if (_context.loadingOrderOut == null)
          {
              return NotFound();
          }
            return await _context.loadingOrderOut.ToListAsync();
        }

        // GET: api/LoadingOrderOuts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoadingOrderOut>> GetLoadingOrderOut(int id)
        {
          if (_context.loadingOrderOut == null)
          {
              return NotFound();
          }
            var loadingOrderOut = await _context.loadingOrderOut.FindAsync(id);

            if (loadingOrderOut == null)
            {
                return NotFound();
            }

            return loadingOrderOut;
        }

        // PUT: api/LoadingOrderOuts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoadingOrderOut(int id, LoadingOrderOut loadingOrderOut)
        {
            if (id != loadingOrderOut.LoadingOrderNumber)
            {
                return BadRequest();
            }

            _context.Entry(loadingOrderOut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoadingOrderOutExists(id))
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

        // POST: api/LoadingOrderOuts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LoadingOrderOut>> PostLoadingOrderOut(LoadingOrderOut loadingOrderOut)
        {
          if (_context.loadingOrderOut == null)
          {
              return Problem("Entity set 'AppDBContext.loadingOrderOut'  is null.");
          }
            _context.loadingOrderOut.Add(loadingOrderOut);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoadingOrderOut", new { id = loadingOrderOut.LoadingOrderNumber }, loadingOrderOut);
        }

        // DELETE: api/LoadingOrderOuts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoadingOrderOut(int id)
        {
            if (_context.loadingOrderOut == null)
            {
                return NotFound();
            }
            var loadingOrderOut = await _context.loadingOrderOut.FindAsync(id);
            if (loadingOrderOut == null)
            {
                return NotFound();
            }

            _context.loadingOrderOut.Remove(loadingOrderOut);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoadingOrderOutExists(int id)
        {
            return (_context.loadingOrderOut?.Any(e => e.LoadingOrderNumber == id)).GetValueOrDefault();
        }
    }
}
