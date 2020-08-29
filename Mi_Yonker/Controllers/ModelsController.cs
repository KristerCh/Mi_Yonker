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
    public class ModelsController : ControllerBase
    {
        private readonly DataContext _context;

        public ModelsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Models
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models>>> Getmodels()
        {
            return await _context.models.ToListAsync();
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models>> GetModels(int id)
        {
            var models = await _context.models.FindAsync(id);

            if (models == null)
            {
                return NotFound();
            }

            return models;
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModels(int id, Models models)
        {
            if (id != models.id)
            {
                return BadRequest();
            }

            _context.Entry(models).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelsExists(id))
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

        // POST: api/Models
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Models>> PostModels(Models models)
        {
            _context.models.Add(models);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModels", new { id = models.id }, models);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Models>> DeleteModels(int id)
        {
            var models = await _context.models.FindAsync(id);
            if (models == null)
            {
                return NotFound();
            }

            _context.models.Remove(models);
            await _context.SaveChangesAsync();

            return models;
        }

        private bool ModelsExists(int id)
        {
            return _context.models.Any(e => e.id == id);
        }
    }
}
