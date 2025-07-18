﻿using Microsoft.AspNetCore.Mvc;
using InternationalSchoolAdministrator_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InternationalSchoolAdministrator_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        // GET: api/<ParentsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

      
        // GET api/<ParentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ParentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ParentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ParentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


//[HttpGet]
//public string GetStudentsProfile(string parentid)
//{
//    StudentModel studentModel = new StudentModel();
//    studentModel.GetStudentByParentID(parentid);
//    return studentModel.ToString();
//}