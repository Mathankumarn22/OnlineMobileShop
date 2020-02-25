﻿using OnlineMobileShop.Entity;
using OnlineMobileShop.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineMobileShop.Controllers
{
    public class AccountController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Account account)
        {
            if (ModelState.IsValid ) 
            {
                UserRespo.Add(account);
                return RedirectToAction("LogIn");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "MailID, Password")]Account account)
        {
            if(UserRespo.Login(account.MailID, account.Password))
            {
                return RedirectToAction("DisplayDetails", "Mobile");
            }
            else
            {
                return View();
            }
        }
        public ActionResult DisplayUserDetails()
        {
            UserRespo userRespo = new UserRespo();
            List<Account> UserDetails = userRespo.GetUser();
            return View(UserDetails);
        }
    }   
}