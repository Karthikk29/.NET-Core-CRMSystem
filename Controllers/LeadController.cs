using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRMSystem.Models;
using CRMSystem.Data;

namespace CRMSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeadController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LeadController(AppDbContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lead>>> GetLeads()
        {
            return await _context.Leads
                .Include(l => l.AssignedToUser)
                .ToListAsync();
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<Lead>> GetLeadById(int id)
        {
            var lead = await _context.Leads
                .Include(l => l.AssignedToUser)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (lead == null)
                return NotFound();

            return lead;
        }

       
        [HttpPost]
        public async Task<ActionResult<Lead>> AddLead(Lead lead)
        {
            _context.Leads.Add(lead);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLeadById), new { id = lead.Id }, lead);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLead(int id, Lead updatedLead)
        {
            if (id != updatedLead.Id)
                return BadRequest();

            _context.Entry(updatedLead).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Leads.Any(l => l.Id == id))
                    return NotFound();

                throw;
            }

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLead(int id)
        {
            var lead = await _context.Leads.FindAsync(id);
            if (lead == null)
                return NotFound();

            _context.Leads.Remove(lead);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
