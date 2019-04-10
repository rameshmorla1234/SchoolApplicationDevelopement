using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EODevelopementApplication.Models;
using EODevelopementApplication.Filters;

namespace EODevelopementApplication.Controllers
{
   
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
       [LoginConterollerActionFilter]
        public IActionResult Register(UserModel user)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View();
        }
    }
}