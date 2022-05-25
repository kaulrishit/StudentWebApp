using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApplication.Models;
using StudentWebApplication.RequestModel;

namespace StudentWebApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        private readonly StudentContext _studentcontext;
        public StudentController(StudentContext a)
        {
            _studentcontext = a;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var getstu = _studentcontext.StudentInfo.ToList();
            return Ok(getstu);
        }

        // GET: api/Student/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {

            var result = _studentcontext.StudentInfo.First(obj => obj.StudentId == id);
            return Ok(result);

        }
        // POST: api/Student
[HttpGet("Student/{value}")]
public IActionResult Get(string value)
        {
            var result = _studentcontext.StudentInfo.Where(obj => obj.StudentName.Contains(value));
            return Ok(result);
        }


        [HttpPost]
        public void Post([FromBody] Class value)
        {
            StudentInfo obj = new StudentInfo();
            obj.StudentName = value.StudentName;
            obj.StudentGender = value.StudentGender;
            obj.StudentAge = value.StudentAge;
            _studentcontext.StudentInfo.Add(obj);
            _studentcontext.SaveChanges();
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
