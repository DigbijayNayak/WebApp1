using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentDetailsController : Controller
    {
        private readonly ILogger<StudentDetailsController> _logger;
        IBusinessLogic _businessLogic;

        public StudentDetailsController(ILogger<StudentDetailsController> logger, IBusinessLogic businessLogic)
        {
            _logger = logger;
            _businessLogic = businessLogic;
        }

        [HttpGet]
        public IEnumerable<StudentEntity> Get(int rollNo)
        {
            var result = _businessLogic.GetFilteredStudentRecord(rollNo);
            return Enumerable.Range(1, 1).Select(index => new StudentEntity
            {
                Name = result.Name,
                RollNo = result.RollNo,
                Section = result.Section,
            })
            .ToArray();
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<UserDetails>>> GetUserDetails()
        //{
        //    return await DbContext.UserDetails.ToListAsync();
        //}

        [HttpGet]
        public IEnumerable<StudentEntity> GetRandom()
        {
            var res = _businessLogic.GetFilteredByRandom();
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
            var result = _businessLogic.GetFilteredByName(name);
            return result.AsEnumerable();
            //return Enumerable.Range(1, 1).Select(index => new StudentEntity
            //{
            //    Name = result.Name,
            //    RollNo = result.RollNo,
            //    Section = result.Section,
            //})
            //.ToArray();
        }
        //[HttpPost]
        //public UserDetails AddUser(UserDetails user)
        //{
        //    return
        //}
        [HttpPost]
        public bool LogInUser(UserDetails user)
        {
            return _businessLogic.GetFilteredById(user);
        }

        [HttpPost]
        public bool SaveUser(UserDetails userEntity)
        {
            return _businessLogic.SavesUserDetailsRecord(userEntity);
        }


        [HttpPost]
        public bool SaveRecord(StudentEntity stdEntity)
        {
            return _businessLogic.SavesStudentRecord(stdEntity);
            //return true; // new BussinessLogic().SavesStudentRecord(stdEntity);
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
