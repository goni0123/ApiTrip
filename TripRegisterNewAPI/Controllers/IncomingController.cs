using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripRegisterNewAPI.Data;
using TripRegisterNewAPI.InsertingModels;
using TripRegisterNewAPI.Models;

namespace TripRegisterNewAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomingController : ControllerBase
    {
        private readonly AppDBContext _context;

        public IncomingController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Incoming
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incoming>>> GetIncoming()
        {
            return await _context.incoming.ToListAsync();
        }

        // GET: api/Incoming/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Incoming>> GetIncoming(int id)
        {
            var incoming = await _context.incoming.FindAsync(id);

            if (incoming == null)
            {
                return NotFound();
            }

            return incoming;
        }

        // POST: api/Incoming
        [HttpPost]
        public async Task<ActionResult<Incoming>> PostIncoming(IncomingInsert incomingInsert)
        {
            var incoming = new Incoming
            {
                Nalog_nr = incomingInsert.Nalog_nr,
                Truck = incomingInsert.Truck,
                RIT = incomingInsert.RIT,
                Start_date = incomingInsert.Start_date,
                End_date = incomingInsert.End_date,
                KM = incomingInsert.KM,
                Work_days = incomingInsert.Work_days,
                Extra_Cost = incomingInsert.Extra_Cost,
                Extra_Cost_Attachment = incomingInsert.Extra_Cost_Attachment,
                Invoice = incomingInsert.Invoice,
                Invoice_Attachment = incomingInsert.Invoice_Attachment,
                Comment = incomingInsert.Comment,
                Comment_Attachment = incomingInsert.Comment_Attachment,
                Check = incomingInsert.Check,
                Driver = incomingInsert.Driver
            };

            _context.incoming.Add(incoming);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIncoming", new { id = incoming.Nalog_nr }, incoming);
        }

        // PUT: api/Incoming/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncoming(int id, IncomingInsert incomingInsert)
        {
            var incoming = await _context.incoming.FindAsync(id);

            if (incoming == null)
            {
                return NotFound();
            }

            incoming.Nalog_nr = incomingInsert.Nalog_nr;
            incoming.Truck = incomingInsert.Truck;
            incoming.RIT = incomingInsert.RIT;
            incoming.Start_date = incomingInsert.Start_date;
            incoming.End_date = incomingInsert.End_date;
            incoming.KM = incomingInsert.KM;
            incoming.Work_days = incomingInsert.Work_days;
            incoming.Extra_Cost = incomingInsert.Extra_Cost;
            incoming.Extra_Cost_Attachment = incomingInsert.Extra_Cost_Attachment;
            incoming.Invoice = incomingInsert.Invoice;
            incoming.Invoice_Attachment = incomingInsert.Invoice_Attachment;
            incoming.Comment = incomingInsert.Comment;
            incoming.Comment_Attachment = incomingInsert.Comment_Attachment;
            incoming.Check = incomingInsert.Check;
            incoming.Driver = incomingInsert.Driver;

            _context.Entry(incoming).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomingExists(id))
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

        // DELETE: api/Incoming/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncoming(int id)
        {
            var incoming = await _context.incoming.FindAsync(id);
            if (incoming == null)
            {
                return NotFound();
            }

            _context.incoming.Remove(incoming);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IncomingExists(int id)
        {
            return _context.incoming.Any(e => e.Nalog_nr == id);
        }
    }
}
