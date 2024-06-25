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
    public class LiquidsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LiquidsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Liquids
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Liquid>>> GetLiquid()
        {
            return await _context.Liquid.ToListAsync();
        }

        // GET: api/Liquids/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Liquid>> GetLiquid(int id)
        {
            var liquid = await _context.Liquid.FindAsync(id);

            if (liquid == null)
            {
                return NotFound();
            }

            return liquid;
        }

        // PUT: api/Liquids/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLiquid(int id, Liquid liquid)
        {
            if (id != liquid.LiquidId)
            {
                return BadRequest();
            }

            _context.Entry(liquid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LiquidExists(id))
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

        // POST: api/Liquids
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Liquid>> PostLiquid(Liquid liquid)
        {
            _context.Liquid.Add(liquid);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLiquid", new { id = liquid.LiquidId }, liquid);
        }

        // DELETE: api/Liquids/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLiquid(int id)
        {
            var liquid = await _context.Liquid.FindAsync(id);
            if (liquid == null)
            {
                return NotFound();
            }

            _context.Liquid.Remove(liquid);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LiquidExists(int id)
        {
            return _context.Liquid.Any(e => e.LiquidId == id);
        }
    }
}
