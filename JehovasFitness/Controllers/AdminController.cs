using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JehovasFitness.Data;
using JehovasFitness.Models;
using Microsoft.AspNetCore.Mvc;

namespace JehovasFitness.Controllers
{
    public class AdminController : Controller
    {
        private UserDbContext context;

        public AdminController(UserDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult UserList()
        {
            IList<UserClass> Users = context.Users.ToList();

            return View(Users);
        }
    }
}