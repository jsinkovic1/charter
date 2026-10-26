using CharterBackend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using System;

namespace CharterBackend.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = new
            {
                time = DateTime.Now,
                foo = "bar",
                test = true
            };
            
            return Ok(res);
        }

    }
}