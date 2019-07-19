using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Commodite_Admissions
{
    [Route("api/[controller]")]
    [ApiController]
    public class Commodite_AdmissionsController : ControllerBase
    {
        private readonly NLHContext _context;

        public Commodite_AdmissionsController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Commodite_Admissions
        [HttpGet]
        public IEnumerable<Commodite_Admission> Getcommodite_Admissions()
        {
            return _context.commodite_Admissions;
        }

        // GET: api/Commodite_Admissions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommodite_Admission([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commodite_Admission = await _context.commodite_Admissions.FindAsync(id);

            if (commodite_Admission == null)
            {
                return NotFound();
            }

            return Ok(commodite_Admission);
        }

        // PUT: api/Commodite_Admissions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommodite_Admission([FromRoute] int id, [FromBody] Commodite_Admission commodite_Admission)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != commodite_Admission.Id_Admission)
            {
                return BadRequest();
            }

            _context.Entry(commodite_Admission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Commodite_AdmissionExists(id))
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

        // POST: api/Commodite_Admissions
        [HttpPost]
        public async Task<IActionResult> PostCommodite_Admission([FromBody] Commodite_Admission commodite_Admission)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.commodite_Admissions.Add(commodite_Admission);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Commodite_AdmissionExists(commodite_Admission.Id_Admission))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCommodite_Admission", new { id = commodite_Admission.Id_Admission }, commodite_Admission);
        }

        // DELETE: api/Commodite_Admissions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommodite_Admission([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commodite_Admission = await _context.commodite_Admissions.FindAsync(id);
            if (commodite_Admission == null)
            {
                return NotFound();
            }

            _context.commodite_Admissions.Remove(commodite_Admission);
            await _context.SaveChangesAsync();

            return Ok(commodite_Admission);
        }

        private bool Commodite_AdmissionExists(int id)
        {
            return _context.commodite_Admissions.Any(e => e.Id_Admission == id);
        }
    }
}