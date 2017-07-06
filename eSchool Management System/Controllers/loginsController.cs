using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using eSchool_Management_System.Models;

namespace eSchool_Management_System.Controllers
{
    public class loginsController : Controller
    {
       // private merry_cliff_academyEntities db = new merry_cliff_academyEntities();
        // GET: logins
        public ActionResult Index()
        {

            return View();
        }

        //POST : Home/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Models.login log )
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (merry_cliff_academyEntities db = new merry_cliff_academyEntities())
                    {
                        var obj = db.logins.FirstOrDefault(a => a.username.Equals(log.username) && a.password.Equals(log.password));
                        if (obj != null)
                        {
                            Session["UserId"] = obj.loginId;
                            Session["username"] = obj.username;
                            return RedirectToAction("Index", "Home");
                        }
                        //=============
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return View(log);
        }


    }
}
