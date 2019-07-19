using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_SERVICES.Controllers.Parents
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        private readonly NLHContext _context;

        public ParentsController(NLHContext context)
        {
            _context = context;
        }

        // GET: api/Parents
        [HttpGet]
        public IEnumerable<Parent> Getparents()
        {
            return _context.parents;
        }

        // GET: api/Parents/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetParent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parent = await _context.parents.FindAsync(id);

            if (parent == null)
            {
                return NotFound();
            }

            return Ok(parent);
        }

        // PUT: api/Parents/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutParent([FromRoute] int id, [FromBody] Parent parent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != parent.Ref_Parent)
            {
                return BadRequest();
            }

            _context.Entry(parent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParentExists(id))
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

        // POST: api/Parents
        [HttpPost]
        public async Task<IActionResult> PostParent([FromBody] Parent parent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.parents.Add(parent);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ParentExists(parent.Ref_Parent))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetParent", new { id = parent.Ref_Parent }, parent);
        }

        // DELETE: api/Parents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parent = await _context.parents.FindAsync(id);
            if (parent == null)
            {
                return NotFound();
            }

            _context.parents.Remove(parent);
            await _context.SaveChangesAsync();

            return Ok(parent);
        }

        private bool ParentExists(int id)
        {
            return _context.parents.Any(e => e.Ref_Parent == id);
        }
    }
}