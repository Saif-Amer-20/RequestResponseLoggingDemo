using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseLoggingDemo.Web.Models;

namespace RequestResponseLoggingDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Employee> GetByID(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest("error");
                var employee = new Employee()
                {
                    ID = id,
                    FirstName = "firstName",
                    LastName = "lastName",
                    DateOfBirth = DateTime.Now.AddYears(-30)
                };

                return Ok(employee);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
            
           
        }
    }
}