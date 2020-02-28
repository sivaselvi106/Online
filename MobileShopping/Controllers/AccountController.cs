using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShopping.Entity;
using MobileShopping.Repository;

namespace MobileShopping.Controllers
{
    public class AccountController : Controller
    {
        AccountRepository accountRepository;
        public AccountController()
        {
            accountRepository = new AccountRepository();
        }
        public ActionResult DisplayUsers()
        {
            IEnumerable<Account> accounts = accountRepository.GetUserDetails();
            return View(accounts);
        }
        [HttpGet]
        [ActionName("SignUp")]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ActionName("SignUp")]
        public ActionResult SignUp_Post()
        {
            Account user = new Account();
            TryUpdateModel(user);
            if (ModelState.IsValid)
            {
                accountRepository.AddUser(user);
                TempData["Message"] = "User added successfully!!!";
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account account)
        {
            Account user = new Account();
            TryUpdateModel(user);
            if (account.MailId.Equals(user.MailId) && account.Password.Equals(user.Password))
            {
                return RedirectToAction("Display");
            }
            return View();
        }
       
    }
}