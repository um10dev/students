using Aeries.Data;
using Aeries.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aeries.Controllers
{
    [EnableCors("_CorsPolicy")]
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
            try
            {
                var students = await _dbContext.StudentData.ToListAsync();
                return students;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
