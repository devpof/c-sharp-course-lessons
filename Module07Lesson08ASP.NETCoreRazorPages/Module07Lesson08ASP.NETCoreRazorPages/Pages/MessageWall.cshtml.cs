using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module07Lesson08ASP.NETCoreRazorPages.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty] // this means you are allowing to send to this property when you post data
        public string Message { get; set; }

        // workaround for Database
        // right way to do it is to have a database and in the OnPost
        // you will have a method that will write the data to the Database so it stores it.
        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Messages.Add(Message); // imagine this is posting to a database instead of adding to a list.
            return Page(); // return to the same page
        }
    }
}
