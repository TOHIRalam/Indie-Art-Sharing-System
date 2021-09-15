using Indie_Art_Sharing_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Indie_Art_Sharing_System.Controllers
{
    public class SigninSignupController : Controller
    {
        private readonly ILogger<SigninSignupController> _logger;

        public SigninSignupController(ILogger<SigninSignupController> logger)
        {
            _logger = logger;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
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
