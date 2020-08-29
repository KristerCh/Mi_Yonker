using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mi_Yonker.Data;
using Mi_Yonker.Modelos;

namespace Mi_Yonker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Partlist_detailsController : ControllerBase
    {
        private readonly DataContext _context;

        public Partlist_detailsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Partlist_details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partlist_details>>> Getpartlist_Details()
        {
            return await _context.partlist_Details.ToListAsync();
        }

        // GET: api/Partlist_details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Partlist_details>> GetPartlist_details(int id)
        {
            var partlist_details = await _context.partlist_Details.FindAsync(id);

            if (partlist_details == null)
            {
                return NotFound();
            }

            return partlist_details;
        }

        // PUT: api/Partlist_details/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartlist_details(int id, Partlist_details partlist_details)
        {
            if (id != partlist_details.id)
            {
                return BadRequest();
            }

            _context.Entry(partlist_details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Partlist_detailsExists(id))
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

        // POST: api/Partlist_details
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Partlist_details>> PostPartlist_details(Partlist_details partlist_details)
        {
            _context.partlist_Details.Add(partlist_details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartlist_details", new { id = partlist_details.id }, partlist_details);
        }

        // DELETE: api/Partlist_details/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Partlist_details>> DeletePartlist_details(int id)
        {
            var partlist_details = await _context.partlist_Details.FindAsync(id);
            if (partlist_details == null)
            {
                return NotFound();
            }

            _context.partlist_Details.Remove(partlist_details);
            await _context.SaveChangesAsync();

            return partlist_details;
        }

        private bool Partlist_detailsExists(int id)
        {
            return _context.partlist_Details.Any(e => e.id == id);
        }
    }
}
