using UsedSale_Car.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UsedSale_Car.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin Login
        Context c = new Context();

        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(Admin ad)
        {
            var info = c.Admins.FirstOrDefault(x => x.AdminName == ad.AdminName && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.AdminName, false);
                Session["AdminName"] = info.AdminName.ToString();
                Session["LastName"] = info.LastName.ToString();
                Session["FirstName"] = info.FirstName.ToString();
                Session["Mail"] = info.Mail.ToString();
                Session["Phone"] = info.Phone.ToString();
                Session["Password"] = info.Password.ToString();
                Session["ID"] = info.ID;

                return RedirectToAction("AdminIndex", "Admin");

            }
            else
                return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("CustomerLogin", "Login");
        }


        // GET: CarOwner Login
        public ActionResult LoginCarOwner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginCarOwner(CarOwner ad)
        {
            var info = c.CarOwners.FirstOrDefault(x => x.LastName == ad.LastName && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.LastName, false);
                Session["LastName"] = info.LastName.ToString();
                Session["FirstName"] = info.FirstName.ToString();
                Session["Mail"] = info.Mail.ToString();
                Session["Phone"] = info.Phone.ToString();
                Session["Password"] = info.Password.ToString();
                Session["ID"] = info.ID;
                return RedirectToAction("CarOwnerIndex", "CarOwner");

            }
            else
            {
                return View();
            }

        }

        public ActionResult LogOutCarOwner()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("CustomerLogin", "Login");
        }


        // GET: Customer Login
        public ActionResult CustomerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomerLogin(Customer ad)
        {

            var info = c.Customers.FirstOrDefault(x => x.Mail == ad.Mail && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Mail, false);
                Session["Mail"] = info.Mail.ToString();
                Session["LastName"] = info.LastName.ToString();
                Session["FirstName"] = info.FirstName.ToString();
                Session["Mail"] = info.Mail.ToString();
                Session["Phone"] = info.Phone.ToString();
                Session["Password"] = info.Password.ToString();
                Session["ID"] = info.ID;
                return RedirectToAction("HomeIndex", "Home");

            }
            else
            {
                return View();
            }

        }
    }
}