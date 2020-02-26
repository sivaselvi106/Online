using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShopping.Entity;

namespace MobileShopping.Controllers
{
    public class AccountController : Controller
    {
       
        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Account account)
        {
            return View();
        }
    }
}