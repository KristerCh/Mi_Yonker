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
    public class Parts_vehicleController : ControllerBase
    {
        private readonly DataContext _context;

        public Parts_vehicleController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Parts_vehicle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parts_vehicle>>> Getparts_Vehicles()
        {
            return await _context.parts_Vehicles.ToListAsync();
        }

        // GET: api/Parts_vehicle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Parts_vehicle>> GetParts_vehicle(int id)
        {
            var parts_vehicle = await _context.parts_Vehicles.FindAsync(id);

            if (parts_vehicle == null)
            {
                return NotFound();
            }

            return parts_vehicle;
        }

        // PUT: api/Parts_vehicle/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParts_vehicle(int id, Parts_vehicle parts_vehicle)
        {
            if (id != parts_vehicle.id)
            {
                return BadRequest();
            }

            _context.Entry(parts_vehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Parts_vehicleExists(id))
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

        // POST: api/Parts_vehicle
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Parts_vehicle>> PostParts_vehicle(Parts_vehicle parts_vehicle)
        {
            _context.parts_Vehicles.Add(parts_vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetParts_vehicle", new { id = parts_vehicle.id }, parts_vehicle);
        }

        // DELETE: api/Parts_vehicle/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Parts_vehicle>> DeleteParts_vehicle(int id)
        {
            var parts_vehicle = await _context.parts_Vehicles.FindAsync(id);
            if (parts_vehicle == null)
            {
                return NotFound();
            }

            _context.parts_Vehicles.Remove(parts_vehicle);
            await _context.SaveChangesAsync();

            return parts_vehicle;
        }

        private bool Parts_vehicleExists(int id)
        {
            return _context.parts_Vehicles.Any(e => e.id == id);
        }
    }
}
