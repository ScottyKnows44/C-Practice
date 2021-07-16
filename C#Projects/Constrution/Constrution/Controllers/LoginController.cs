using Constrution.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constrution.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(Owner owner) {

            if (owner.UserName == "steve" && owner.Password == "123")
            {
                return RedirectToAction("Index", "Home");
            }
            else {
                return View("Index", owner);
            }
            
        }

    }
}
