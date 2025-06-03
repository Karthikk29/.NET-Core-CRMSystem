using Microsoft.AspNetCore.Mvc;
using CRMSystem.Data;
using System.Linq;

namespace CRMSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDashboard()
        {
            var totalLeads = _context.Leads.Count();
            var totalContacts = _context.Contacts.Count();
            var closedDeals = _context.Deals.Count(d => d.Stage == "Closed Won");

            return Ok(new
            {
                totalLeads,
                totalContacts,
                closedDeals
            });
        }
    }
}
