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
    public class PartlistsController : ControllerBase
    {
        private readonly DataContext _context;

        public PartlistsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Partlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partlist>>> Getpartlist()
        {
            return await _context.partlist.ToListAsync();
        }

        // GET: api/Partlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Partlist>> GetPartlist(int id)
        {
            var partlist = await _context.partlist.FindAsync(id);

            if (partlist == null)
            {
                return NotFound();
            }

            return partlist;
        }

        // PUT: api/Partlists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartlist(int id, Partlist partlist)
        {
            if (id != partlist.id)
            {
                return BadRequest();
            }

            _context.Entry(partlist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartlistExists(id))
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

        // POST: api/Partlists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Partlist>> PostPartlist(Partlist partlist)
        {
            _context.partlist.Add(partlist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartlist", new { id = partlist.id }, partlist);
        }

        // DELETE: api/Partlists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Partlist>> DeletePartlist(int id)
        {
            var partlist = await _context.partlist.FindAsync(id);
            if (partlist == null)
            {
                return NotFound();
            }

            _context.partlist.Remove(partlist);
            await _context.SaveChangesAsync();

            return partlist;
        }

        private bool PartlistExists(int id)
        {
            return _context.partlist.Any(e => e.id == id);
        }
    }
}
