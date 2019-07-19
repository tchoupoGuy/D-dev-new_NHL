using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Compagnie_Assurances
{
    [Route("api/[controller]")]
    [ApiController]
    public class Compagnie_AssurancesController : ControllerBase
    {
        private readonly NLHContext _context;

        public Compagnie_AssurancesController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Compagnie_Assurances
        [HttpGet]
        public IEnumerable<Compagnie_Assurance> Getassurances()
        {
            return _context.assurances;
        }

        // GET: api/Compagnie_Assurances/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompagnie_Assurance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var compagnie_Assurance = await _context.assurances.FindAsync(id);

            if (compagnie_Assurance == null)
            {
                return NotFound();
            }

            return Ok(compagnie_Assurance);
        }

        // PUT: api/Compagnie_Assurances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompagnie_Assurance([FromRoute] int id, [FromBody] Compagnie_Assurance compagnie_Assurance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != compagnie_Assurance.Id_Compagnie)
            {
                return BadRequest();
            }

            _context.Entry(compagnie_Assurance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Compagnie_AssuranceExists(id))
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

        // POST: api/Compagnie_Assurances
        [HttpPost]
        public async Task<IActionResult> PostCompagnie_Assurance([FromBody] Compagnie_Assurance compagnie_Assurance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.assurances.Add(compagnie_Assurance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompagnie_Assurance", new { id = compagnie_Assurance.Id_Compagnie }, compagnie_Assurance);
        }

        // DELETE: api/Compagnie_Assurances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompagnie_Assurance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var compagnie_Assurance = await _context.assurances.FindAsync(id);
            if (compagnie_Assurance == null)
            {
                return NotFound();
            }

            _context.assurances.Remove(compagnie_Assurance);
            await _context.SaveChangesAsync();

            return Ok(compagnie_Assurance);
        }

        private bool Compagnie_AssuranceExists(int id)
        {
            return _context.assurances.Any(e => e.Id_Compagnie == id);
        }
    }
}