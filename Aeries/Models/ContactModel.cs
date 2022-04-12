using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aeries.Models
{
    [Keyless]
    public class ContactModel
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Relationship { get; set; }
        public string EmailAddress { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
