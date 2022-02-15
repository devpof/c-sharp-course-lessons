using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module07Lesson12ASPNETCoreAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module07Lesson12ASPNETCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageWallController : ControllerBase
    {
        private ILogger _logger;

        public MessageWallController(ILogger<MessageWallController> logger)
        {
            _logger = logger;
        }

        // GET: api/<MessageWallController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> output = new List<string>
            {
                "Hello World",
                "How are you?"
            };

            return output;
        }

        // GET: api/<MessageWallController>?message=Test&id=4
        // if you do a URL query
        [HttpGet]
        public IEnumerable<string> Get(String message = "", int id = 0)
        {
            List<string> output = new List<string>
            {
                "Hello World",
                "How are you?"
            };

            if (string.IsNullOrWhiteSpace(message) == false)
            {
                output.Add(message);
            }

            return output;
        }

        // GET api/<MessageWallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageWallController>
        [HttpPost]
        public void Post([FromBody] MessageModel message)
        {
            // AMI information on logging in C#. Tim Corey has a content on it.
            // the names do not have to match, it is order based.
            // if you have multiple {} it will match it with the variables in the order they are declared.
            _logger.LogInformation("Our message was {Message}", message.Message);
        }

        // PUT api/<MessageWallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageWallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
