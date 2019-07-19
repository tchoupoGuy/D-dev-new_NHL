using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Departements
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementsController : ControllerBase
    {
        private readonly NLHContext _context;

        public DepartementsController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Departements
        [HttpGet]
        public IEnumerable<Departement> Getdepartements()
        {
            return _context.departements;
        }

        // GET: api/Departements/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartement([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var departement = await _context.departements.FindAsync(id);

            if (departement == null)
            {
                return NotFound();
            }

            return Ok(departement);
        }

        // PUT: api/Departements/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartement([FromRoute] int id, [FromBody] Departement departement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != departement.Id_Departement)
            {
                return BadRequest();
            }

            _context.Entry(departement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartementExists(id))
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

        // POST: api/Departements
        [HttpPost]
        public async Task<IActionResult> PostDepartement([FromBody] Departement departement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.departements.Add(departement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartement", new { id = departement.Id_Departement }, departement);
        }

        // DELETE: api/Departements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartement([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var departement = await _context.departements.FindAsync(id);
            if (departement == null)
            {
                return NotFound();
            }

            _context.departements.Remove(departement);
            await _context.SaveChangesAsync();

            return Ok(departement);
        }

        private bool DepartementExists(int id)
        {
            return _context.departements.Any(e => e.Id_Departement == id);
        }
    }
}