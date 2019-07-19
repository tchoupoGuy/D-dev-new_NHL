using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Factures
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturesController : ControllerBase
    {
        private readonly NLHContext _context;

        public FacturesController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Factures
        [HttpGet]
        public IEnumerable<Facture> Getfactures()
        {
            return _context.factures;
        }

        // GET: api/Factures/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFacture([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var facture = await _context.factures.FindAsync(id);

            if (facture == null)
            {
                return NotFound();
            }

            return Ok(facture);
        }

        // PUT: api/Factures/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacture([FromRoute] int id, [FromBody] Facture facture)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != facture.Num_Facture)
            {
                return BadRequest();
            }

            _context.Entry(facture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactureExists(id))
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

        // POST: api/Factures
        [HttpPost]
        public async Task<IActionResult> PostFacture([FromBody] Facture facture)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.factures.Add(facture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacture", new { id = facture.Num_Facture }, facture);
        }

        // DELETE: api/Factures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFacture([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var facture = await _context.factures.FindAsync(id);
            if (facture == null)
            {
                return NotFound();
            }

            _context.factures.Remove(facture);
            await _context.SaveChangesAsync();

            return Ok(facture);
        }

        private bool FactureExists(int id)
        {
            return _context.factures.Any(e => e.Num_Facture == id);
        }
    }
}