using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module07Lesson09ASP.NETCoreRazorPagesMiniProject.Pages
{
    public class PeopleModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
