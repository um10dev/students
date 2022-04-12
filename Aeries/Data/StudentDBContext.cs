using Students.Models;
using Microsoft.EntityFrameworkCore;

namespace Students.Data
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

        public DbSet<StudentModel> StudentData { get; set; }
    }
}
