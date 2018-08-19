using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JehovasFitness.ViewModels;
using JehovasFitness.Models;
using JehovasFitness.Data;

namespace JehovasFitness.Controllers
{
    public class LoginSignupController : Controller
    {
        private UserDbContext context;

        public LoginSignupController(UserDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            return View(loginViewModel);
        }

        public IActionResult Signup()
        {
            RegisterUserViewModel registerUserViewModel = new RegisterUserViewModel();
            return View(registerUserViewModel);
        }

        [HttpPost]
        public IActionResult Signup(RegisterUserViewModel registerUserViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new User to my existing Users
                UserClass newUser = new UserClass
                {
                    FirstName = registerUserViewModel.FirstName,
                    LastName = registerUserViewModel.LastName,
                    UserName = registerUserViewModel.UserName,
                    Email = registerUserViewModel.Email,
                    Password = registerUserViewModel.Password,
                    Admin = false,
                    RegDate = DateTime.Now.Date
                };

                // TODO ensure unique username and email address 
               
                context.Users.Add(newUser);
                context.SaveChanges();
                // save registration to database
                return Redirect("/Welcome?name=" + registerUserViewModel.FirstName);
            }
            
            return View(registerUserViewModel);
        }

        public IActionResult Welcome(string name)
        {
            return View(name);
        }
    }
}