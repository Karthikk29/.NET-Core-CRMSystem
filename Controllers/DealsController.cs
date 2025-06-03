using Microsoft.AspNetCore.Mvc;
using CRMSystem.Models; 
using CRMSystem.Data;   
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class DealsController : ControllerBase
{
    private readonly AppDbContext _context;

    public DealsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateDeal(Deal deal)
    {
        _context.Deals.Add(deal);
        _context.SaveChanges();
        return Ok(deal);
    }

    [HttpGet]
    public IActionResult GetDeals()
    {
        var deals = _context.Deals.ToList();
        return Ok(deals);
    }
}
