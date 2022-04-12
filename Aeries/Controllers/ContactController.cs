using Students.Data;
using Students.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Students.Controllers
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
        public async Task<ActionResult<List<ContactModel>>> GetContactsByStudentId(int id)
        {
            try
            {
                var contacts = from x in _dbContext.ContactData where x.StudentId == id select x;
                var contactsTask = await contacts.ToListAsync();
                return Ok(contactsTask);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
