using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module07Lesson13ASPNetCoreAPIMiniProject.Models;

namespace Module07Lesson13ASPNetCoreAPIMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] AddressModel data)
        {
            _logger.LogInformation("The Address was logged as {Address}", data);
        }
    }
}
