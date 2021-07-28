using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/User")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match. Please try again.";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}
