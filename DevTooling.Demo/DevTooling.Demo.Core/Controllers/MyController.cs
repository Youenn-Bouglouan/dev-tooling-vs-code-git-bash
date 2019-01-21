using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevTooling.Demo.Core.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class MyController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var someString = "this is a string";
            var response = new[] { "value1", "value2", someString };

            return Ok(response);
        }

        // GET api/values
        [HttpGet("ex")]
        public IActionResult GetWithException()
        {
            var someString = "this is a string";
            var response = new[] { "value1", "value2", someString };

            return Ok(response[4]);
        }
    }
}
