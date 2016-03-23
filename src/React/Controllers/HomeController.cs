﻿using System.Security.Claims;
using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;
using React.Models.Api;
using Microsoft.AspNet.Identity;
using React.Models;

namespace React.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
            :base(userManager, 
                 signInManager)
        {
        }

        public async Task<IActionResult> Index(string greeting = "Hello!")
        {
            return View("js-{auto}", await BuildState());
        }

        [Route("about")]
        public async Task<IActionResult> About()
        {
            return View("js-{auto}", await BuildState());
        }

        [Route("contact")]
        public async Task<IActionResult> Contact()
        {
            return View("js-{auto}", await BuildState());
        }
    }
}
