using Aeries.Models;
using Microsoft.EntityFrameworkCore;

namespace Aeries.Data
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

        public DbSet<StudentModel> StudentData { get; set; }
    }
}
