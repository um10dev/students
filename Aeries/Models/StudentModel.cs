using Microsoft.EntityFrameworkCore;

namespace Students.Models
{
    [Keyless]
    public class StudentModel
    {
        public int SchoolCode { get; set; }
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
