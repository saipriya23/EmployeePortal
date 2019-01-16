using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeePortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EmployeeFormController : ControllerBase
    {
        List<EmployeeList> employee = new List<EmployeeList>()
        {
            new EmployeeList{Id=1,EmployeeName="John",Designation="software engineer",Experience=2},
            new EmployeeList{Id=2,EmployeeName="Mike",Designation="senior software engineer",Experience=4},
            new EmployeeList{Id=3,EmployeeName="Sam",Designation=" software engineer",Experience=2},
            new EmployeeList{Id=4,EmployeeName="Kiran",Designation="Technical Lead",Experience=10},
            new EmployeeList{Id=5,EmployeeName="Arun",Designation="senior software engineer",Experience=5},
        };
        [HttpGet]
        [Route("GetEmployees")]
        public List<EmployeeList> GetEmployees()
        {
            return employee;
        }
        [Route("GetEmployee")]
         public List<EmployeeList>  GetEmployee([FromBody] EmployeeList value)
         {
            employee.Add(value);
            return employee;
         }
    }
}