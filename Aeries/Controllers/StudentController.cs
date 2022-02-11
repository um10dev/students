using Aeries.Data;
using Aeries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aeries.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController: ControllerBase
    {
        private readonly StudentDBContext _dbContext;

        public StudentController(StudentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentModel>>> GetStudents()
        {
            var students = await _dbContext.StudentData.ToListAsync();
            return students;
        }
    }
}
