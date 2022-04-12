using Students.Models;
using Microsoft.EntityFrameworkCore;

namespace Students.Data
{
    public class ContactDBContext: DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options) { }

        public DbSet<ContactModel> ContactData { get; set; }
    }
}
