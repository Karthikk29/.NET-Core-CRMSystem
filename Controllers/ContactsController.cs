using Microsoft.AspNetCore.Mvc;
using CRMSystem.Models; 
using CRMSystem.Data;   
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ContactsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult CreateContact(Contact contact)
    {
        _context.Contacts.Add(contact);
        _context.SaveChanges();
        return Ok(contact);
    }

    [HttpGet]
    public IActionResult GetContacts()
    {
        var contacts = _context.Contacts.ToList();
        return Ok(contacts);
    }
}
