using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JehovasFitness.Controllers
{
    public class LoginSignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {

        }

        [HttpPost]
        public IActionResult Register()
        {

        }
    }
}