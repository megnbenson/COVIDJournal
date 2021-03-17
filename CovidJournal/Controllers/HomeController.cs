using CovidJournal.Data;
using CovidJournal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CovidJournal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.User = GetCurrentUser();
            return View();
        }

        // Helper function to get user
        public ApplicationUser GetCurrentUser()
        {
            // user name of currently logged in user
            var userNameOfCurrentlyLoggedInUser = User.Identity.Name;

            // find in user table and get all details
            var user = _context.Users.Where(u => u.UserName == userNameOfCurrentlyLoggedInUser);

            return user.FirstOrDefault();
        }

        //public ApplicationUser GetRole()
        //{
        //    // user name of currently logged in user
        //    var userNameOfCurrentlyLoggedInUser = User.Identity.Name;

        //    // find in user table and get all details
        //    var user = _context.UserRoles;

        //    return user.FirstOrDefault();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
