using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Type_Lits
{
    [Route("api/[controller]")]
    [ApiController]
    public class Type_LitsController : ControllerBase
    {
        private readonly NLHContext _context;

        public Type_LitsController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Type_Lits
        [HttpGet]
        public IEnumerable<Type_Lit> GetType_Lits()
        {
            return _context.Type_Lits;
        }

        // GET: api/Type_Lits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetType_Lit([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var type_Lit = await _context.Type_Lits.FindAsync(id);

            if (type_Lit == null)
            {
                return NotFound();
            }

            return Ok(type_Lit);
        }

        // PUT: api/Type_Lits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutType_Lit([FromRoute] int id, [FromBody] Type_Lit type_Lit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != type_Lit.Numero_Type)
            {
                return BadRequest();
            }

            _context.Entry(type_Lit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Type_LitExists(id))
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

        // POST: api/Type_Lits
        [HttpPost]
        public async Task<IActionResult> PostType_Lit([FromBody] Type_Lit type_Lit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Type_Lits.Add(type_Lit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetType_Lit", new { id = type_Lit.Numero_Type }, type_Lit);
        }

        // DELETE: api/Type_Lits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteType_Lit([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var type_Lit = await _context.Type_Lits.FindAsync(id);
            if (type_Lit == null)
            {
                return NotFound();
            }

            _context.Type_Lits.Remove(type_Lit);
            await _context.SaveChangesAsync();

            return Ok(type_Lit);
        }

        private bool Type_LitExists(int id)
        {
            return _context.Type_Lits.Any(e => e.Numero_Type == id);
        }
    }
}