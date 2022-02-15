using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module07Lesson12ASPNETCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : ControllerBase
    {
        // GET: api/<HomeworkController>
        [HttpGet]
        public string Get(String firstName = "", String lastName = "")
        {
            if (string.IsNullOrWhiteSpace(firstName) == true || 
                string.IsNullOrWhiteSpace(lastName) == true)
            {
                return "Sorry, I do not know you.";
            }

            return $"Hi {firstName} {lastName}";
        }
        
    }
}
