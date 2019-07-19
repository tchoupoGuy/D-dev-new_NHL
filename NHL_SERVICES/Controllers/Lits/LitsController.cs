using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Lits
{
    [Route("api/[controller]")]
    [ApiController]
    public class LitsController : ControllerBase
    {
        private readonly NLHContext _context;

        public LitsController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Lits
        [HttpGet]
        public IEnumerable<Lit> Getlits()
        {
            return _context.lits;
        }

        // GET: api/Lits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLit([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lit = await _context.lits.FindAsync(id);

            if (lit == null)
            {
                return NotFound();
            }

            return Ok(lit);
        }

        // PUT: api/Lits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLit([FromRoute] int id, [FromBody] Lit lit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lit.Numero_Lit)
            {
                return BadRequest();
            }

            _context.Entry(lit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LitExists(id))
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

        // POST: api/Lits
        [HttpPost]
        public async Task<IActionResult> PostLit([FromBody] Lit lit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.lits.Add(lit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLit", new { id = lit.Numero_Lit }, lit);
        }

        // DELETE: api/Lits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLit([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lit = await _context.lits.FindAsync(id);
            if (lit == null)
            {
                return NotFound();
            }

            _context.lits.Remove(lit);
            await _context.SaveChangesAsync();

            return Ok(lit);
        }

        private bool LitExists(int id)
        {
            return _context.lits.Any(e => e.Numero_Lit == id);
        }
    }
}