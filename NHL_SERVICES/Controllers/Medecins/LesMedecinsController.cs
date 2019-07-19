using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Medecins
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LesMedecinsController : ControllerBase
    {
        private readonly NLHContext _context;

        public LesMedecinsController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/LesMedecins
        [HttpGet]
        public IEnumerable<Medecin> Getmedecins()
        {
            return _context.medecins;
        }

        // GET: api/LesMedecins/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedecin([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var medecin = await _context.medecins.FindAsync(id);

            if (medecin == null)
            {
                return NotFound();
            }

            return Ok(medecin);
        }

        // PUT: api/LesMedecins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedecin([FromRoute] string id, [FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != medecin.Id_Medecin)
            {
                return BadRequest();
            }

            _context.Entry(medecin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedecinExists(id))
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

        // POST: api/LesMedecins
        [HttpPost]
        public async Task<IActionResult> PostMedecin([FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.medecins.Add(medecin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MedecinExists(medecin.Id_Medecin))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMedecin", new { id = medecin.Id_Medecin }, medecin);
        }

        // DELETE: api/LesMedecins/5
        /// <summary>
        /// Deletes a specific Les Medecins.
        /// </summary>
        /// <param name="id"></param> 
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedecin([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var medecin = await _context.medecins.FindAsync(id);
            if (medecin == null)
            {
                return NotFound();
            }

            _context.medecins.Remove(medecin);
            await _context.SaveChangesAsync();

            return Ok(medecin);
        }

        private bool MedecinExists(string id)
        {
            return _context.medecins.Any(e => e.Id_Medecin == id);
        }
    }
}