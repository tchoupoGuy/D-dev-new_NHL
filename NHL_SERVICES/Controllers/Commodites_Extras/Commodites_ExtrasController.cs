using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Commodites_Extras
{
    [Route("api/[controller]")]
    [ApiController]
    public class Commodites_ExtrasController : ControllerBase
    {
        private readonly NLHContext _context;

        public Commodites_ExtrasController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Commodites_Extras
        [HttpGet]
        public IEnumerable<Commodites_Extra> Getcommodites_Extras()
        {
            return _context.commodites_Extras;
        }

        // GET: api/Commodites_Extras/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommodites_Extra([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commodites_Extra = await _context.commodites_Extras.FindAsync(id);

            if (commodites_Extra == null)
            {
                return NotFound();
            }

            return Ok(commodites_Extra);
        }

        // PUT: api/Commodites_Extras/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommodites_Extra([FromRoute] int id, [FromBody] Commodites_Extra commodites_Extra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != commodites_Extra.Id_Commodites)
            {
                return BadRequest();
            }

            _context.Entry(commodites_Extra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Commodites_ExtraExists(id))
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

        // POST: api/Commodites_Extras
        [HttpPost]
        public async Task<IActionResult> PostCommodites_Extra([FromBody] Commodites_Extra commodites_Extra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.commodites_Extras.Add(commodites_Extra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommodites_Extra", new { id = commodites_Extra.Id_Commodites }, commodites_Extra);
        }

        // DELETE: api/Commodites_Extras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommodites_Extra([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commodites_Extra = await _context.commodites_Extras.FindAsync(id);
            if (commodites_Extra == null)
            {
                return NotFound();
            }

            _context.commodites_Extras.Remove(commodites_Extra);
            await _context.SaveChangesAsync();

            return Ok(commodites_Extra);
        }

        private bool Commodites_ExtraExists(int id)
        {
            return _context.commodites_Extras.Any(e => e.Id_Commodites == id);
        }
    }
}