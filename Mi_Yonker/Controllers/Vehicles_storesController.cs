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
    public class Vehicles_storesController : ControllerBase
    {
        private readonly DataContext _context;

        public Vehicles_storesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Vehicles_stores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicles_stores>>> Getvehicles_Stores()
        {
            return await _context.vehicles_Stores.ToListAsync();
        }

        // GET: api/Vehicles_stores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicles_stores>> GetVehicles_stores(int id)
        {
            var vehicles_stores = await _context.vehicles_Stores.FindAsync(id);

            if (vehicles_stores == null)
            {
                return NotFound();
            }

            return vehicles_stores;
        }

        // PUT: api/Vehicles_stores/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicles_stores(int id, Vehicles_stores vehicles_stores)
        {
            if (id != vehicles_stores.id)
            {
                return BadRequest();
            }

            _context.Entry(vehicles_stores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Vehicles_storesExists(id))
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

        // POST: api/Vehicles_stores
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vehicles_stores>> PostVehicles_stores(Vehicles_stores vehicles_stores)
        {
            _context.vehicles_Stores.Add(vehicles_stores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehicles_stores", new { id = vehicles_stores.id }, vehicles_stores);
        }

        // DELETE: api/Vehicles_stores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehicles_stores>> DeleteVehicles_stores(int id)
        {
            var vehicles_stores = await _context.vehicles_Stores.FindAsync(id);
            if (vehicles_stores == null)
            {
                return NotFound();
            }

            _context.vehicles_Stores.Remove(vehicles_stores);
            await _context.SaveChangesAsync();

            return vehicles_stores;
        }

        private bool Vehicles_storesExists(int id)
        {
            return _context.vehicles_Stores.Any(e => e.id == id);
        }
    }
}
