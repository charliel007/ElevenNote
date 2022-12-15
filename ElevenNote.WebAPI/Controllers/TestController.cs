using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElevenNote.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private List<string> people = new List<string>{"Bill","Tim","Larry"};

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(people);
        }
    }
}