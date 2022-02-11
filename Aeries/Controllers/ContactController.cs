using Aeries.Data;
using Aeries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aeries.Controllers
{
    [ApiController]
    [Route("api/Contact")]
    public class ContactController : ControllerBase
    {
        private readonly ContactDBContext _dbContext;

        public ContactController(ContactDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<ContactModel>>> GetContacts(int id)
        {
            var contacts = from x in _dbContext.ContactData where x.StudentId == id select x;
            var contactsTask = await contacts.ToListAsync();
            return contactsTask;
        }
    }
}
