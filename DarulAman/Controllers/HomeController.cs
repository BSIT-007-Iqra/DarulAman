using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DarulAman.Models;
namespace DarulAman.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Models.Model1();
        public ActionResult IndexAdmin()
        {
            return View();
        }
         public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Mosque()
        {
            return View();
        }
         public ActionResult IndexCustomer()
        {
            return View();
        }
         public ActionResult Donate()
        {
            return View();
        }
         public ActionResult Event()
        {
            return View();
        }
         public ActionResult Team()
        {
            return View();
        }
         public ActionResult Prayer()
        {
            return View();
        }
         public ActionResult Teaching()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        } 
        public ActionResult Library()
        {
            return View();
        }
      public ActionResult GYM()
        {
            return View();
        }
      public ActionResult SlaughterHouse()
        {
            return View();
        }
      public ActionResult Translator()
        {
            return View();
        }
       public ActionResult School()
        {
            return View();
        }
       public ActionResult Volunteer()
        {
            return View();
        }
        public ActionResult Marriage()
        {
            return View();
        }
        public ActionResult Funeral()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_Admin a)
        { 
            var check = db.tbl_Admin.Where(x => x.EMAIL == a.EMAIL && x.PASSWORD == a.PASSWORD).FirstOrDefault();
            if(check != null)
            {
                Session["a"] = check;
              return RedirectToAction("IndexAdmin","Home");
             }
            else
            {
                ViewBag.Message = "Invalid Email and Password, Please Enter Valid Email & Password ";
                return View();
            }
        }
    }
}