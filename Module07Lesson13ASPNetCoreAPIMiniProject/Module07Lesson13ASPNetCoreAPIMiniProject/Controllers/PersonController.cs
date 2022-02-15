using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module07Lesson13ASPNetCoreAPIMiniProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module07Lesson13ASPNetCoreAPIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel data)
        {
            _logger.LogInformation("The person was logged as {Person}", data);
        }
    }
}
