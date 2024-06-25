using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AquaAi.Data;
using AquaAi.shared.Models;

namespace AquaAi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorKitsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SensorKitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SensorKits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SensorKit>>> GetSensorKit()
        {
            return await _context.SensorKit.ToListAsync();
        }

        // GET: api/SensorKits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SensorKit>> GetSensorKit(int id)
        {
            var sensorKit = await _context.SensorKit.FindAsync(id);

            if (sensorKit == null)
            {
                return NotFound();
            }

            return sensorKit;
        }

        // PUT: api/SensorKits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSensorKit(int id, SensorKit sensorKit)
        {
            if (id != sensorKit.KitId)
            {
                return BadRequest();
            }

            _context.Entry(sensorKit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SensorKitExists(id))
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

        // POST: api/SensorKits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SensorKit>> PostSensorKit(SensorKit sensorKit)
        {
            _context.SensorKit.Add(sensorKit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSensorKit", new { id = sensorKit.KitId }, sensorKit);
        }

        // DELETE: api/SensorKits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSensorKit(int id)
        {
            var sensorKit = await _context.SensorKit.FindAsync(id);
            if (sensorKit == null)
            {
                return NotFound();
            }

            _context.SensorKit.Remove(sensorKit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SensorKitExists(int id)
        {
            return _context.SensorKit.Any(e => e.KitId == id);
        }
    }
}
