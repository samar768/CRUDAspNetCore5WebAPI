using CRUD_BAL.Service;
using CRUD_DAL.Interface;
using CRUD_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAspNetCore5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDetailsController : ControllerBase
    {
        private readonly StudentService _studentService;

        private readonly IRepositoryStudent<StudentDetails> _studentrepository;

        public StudentDetailsController(IRepositoryStudent<StudentDetails> studentRepository, StudentService studentservice)
        {
            _studentService = studentservice;
            _studentrepository = studentRepository;

        }
        //Add Person
        [HttpPost("Addstudent")]
        public async Task<Object> AddStudent([FromBody] StudentDetails student)
        {
            try
            {
                await _studentService.AddStudent(student);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //GET All Person
        [HttpGet("GetAllStudent")]
        public Object GetAllStudents()
        {
            var data = _studentService.GetAllStudent();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }


    }
}