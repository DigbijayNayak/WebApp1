using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentDetailsController : Controller
    {
        private readonly ILogger<StudentDetailsController> _logger;

        public StudentDetailsController(ILogger<StudentDetailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<StudentEntity> Get(int rollNo)
        {
            var result = new BussinessLogic().GetFilteredStudentRecord(rollNo);
            return Enumerable.Range(1, 1).Select(index => new StudentEntity
            {
                Name = result.Name,
                RollNo = result.RollNo,
                Section = result.Section,
            })
            .ToArray();
        }

        [HttpGet]
        public IEnumerable<StudentEntity> GetRandom()
        {
            var res = new BussinessLogic().GetFilteredByRandom();
            return Enumerable.Range(1,1).Select(index => new StudentEntity{
                Name = res.Name,
                RollNo = res.RollNo,
                Section = res.Section,
            })
            .ToArray();
        }


        [HttpGet]
        public IEnumerable<StudentEntity> GetName(string name)
        {
            var result = new BussinessLogic().GetFilteredByName(name);
            return result.AsEnumerable();
            //return Enumerable.Range(1, 1).Select(index => new StudentEntity
            //{
            //    Name = result.Name,
            //    RollNo = result.RollNo,
            //    Section = result.Section,
            //})
            //.ToArray();
        }
        [HttpPost]
        public bool SaveRecord(StudentEntity stdEntity)
        {
            return new BussinessLogic().SavesStudentRecord(stdEntity);
        }

        //[HttpGet, Route("/rollNo/{id}")]
        //public async Task<IActionResult> GetStudents(StudentEntity student)
        //{
        //    if (!string.IsNullOrEmpty(student.Name))
        //    {
        //        var res = student.Where(
        //            student => student.Name.ToLower().Contains(student.Name.ToLower()));
        //    }
        //    return res;
        //}
        //[HttpGet, Route("/rollNo/{id}")]
        //public IActionResult StudentEntity(int id)
        //{
        //    var =
        //}
    }
}
