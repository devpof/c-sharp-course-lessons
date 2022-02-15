using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module07Lesson10ASPNETCoreMVCMiniProject.Models;

namespace Module07Lesson10ASPNETCoreMVCMiniProject.Controllers
{
    public class AddressController : Controller
    {
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        // change the collection parameter to use the AddressModel so that the ModelState can be accurate.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddressModel data)
        {
            if (ModelState.IsValid == false)
            {
                // this shows in the console.
                _logger.LogWarning("The user submitted an invalid Address upon Create.");
                return View();
            }

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
