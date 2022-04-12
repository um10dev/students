using Aeries.Models;
using Microsoft.EntityFrameworkCore;

namespace Aeries.Data
{
    public class ContactDBContext: DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options) { }

        public DbSet<ContactModel> ContactData { get; set; }
    }
}
