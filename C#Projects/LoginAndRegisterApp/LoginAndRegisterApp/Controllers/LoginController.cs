using LoginAndRegisterApp.Models;
using LoginAndRegisterApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAndRegisterApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel) 
        {
            SecurityService security = new SecurityService();

            if (security.IsValid(userModel))
            {
                return View("LoginSuccess", userModel);
            }
            else {
                return View("LoginFailure", userModel);
            }
                  
        }
    }
}
