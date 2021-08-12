using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route(template:"[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Get all student");
        }

        [HttpGet(template:"{code}")]
        public IActionResult GetA(string code)
        {
            return Ok("get this " + code + " department data");
        }

        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("Insert new department");
        }

        [HttpPut(template: "{code}")]
        public IActionResult Update(string code)
        {
            return Ok("updated this " + code + " department data");
        }

        [HttpDelete(template: "{code}")]
        public IActionResult Delete(string code)
        {
            return Ok("Deleted this " + code + " department data");
        }

    }
}
