using UsedSale_Car.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace UsedSale_Car.Controllers
{
    public class AdminController : Controller
    {
        Context ca = new Context();
        CarListing cbm = new CarListing();
        // GET: Admin

        [Authorize]
        public ActionResult AdminIndex()
        {
            cbm.CarTake = ca.Cars.Where(x => x.Approve == true).ToList();
            string adminName = Session["AdminName"] as string;
            string lastName = Session["LastName"] as string;
            string firstName = Session["FirstName"] as string;
            string mail = Session["Mail"] as string;
            string phone = Session["Phone"] as string;
            string password = Session["Password"] as string;
            int id = 0;

            //id eşleme
            if (Session["ID"] != null && int.TryParse(Session["ID"].ToString(), out int parsedId))
            {
                id = parsedId;
            }

            // View'a kullanıcı bilgilerini taşımak
            ViewBag.AdminName = adminName;
            ViewBag.LastName = lastName;
            ViewBag.FirstName = firstName;
            ViewBag.Mail = mail;
            ViewBag.Phone = phone;
            ViewBag.Password = password;
            ViewBag.ID = id;
            return View(cbm);
        }

        // GET: Admin (araba ekleme)
        [HttpGet]
        public ActionResult NewCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCar(Car c)
        {
            c.Approve = false;
            ca.Cars.Add(c);
            ca.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        // GET: Admin (araba silme)
        public ActionResult DeleteCar(int id)
        {
            var findedCar = ca.Cars.Find(id);
            ca.Cars.Remove(findedCar);
            ca.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        // GET: Admin (araba güncelleme)
        public ActionResult GetCar(int id=0)
        {
            var findedCar2 = ca.Cars.Find(id);
            return View("GetCar", findedCar2);
        }
        public ActionResult UpdateCar(Car c)
        {
            var findedCar3 = ca.Cars.Find(c.ID);
            findedCar3.Brand.BrandName = c.Brand.BrandName;
            findedCar3.Model.ModelName = c.Model.ModelName;
            findedCar3.PhotoCarURL = c.PhotoCarURL;
            findedCar3.Year = c.Year;
            findedCar3.CarType.Name = c.CarType.Name;
            findedCar3.City.Name = c.City.Name;
            findedCar3.Color.Name = c.Color.Name;
            findedCar3.Description = c.Description;
            findedCar3.Doors = c.Doors;
            findedCar3.Engine = c.Engine;
            findedCar3.Mileage = c.Mileage;
            findedCar3.Price = c.Price;
            findedCar3.FuelType = c.FuelType;
            findedCar3.GearType = c.GearType;
            findedCar3.GlassCeiling = c.GlassCeiling;
            findedCar3.ParkingSensor = c.ParkingSensor;
            findedCar3.CentralLocking = c.CentralLocking;
            findedCar3.FoldableMirror = c.FoldableMirror;
            findedCar3.Approve = c.Approve;
            ca.SaveChanges();
            return RedirectToAction("AdminIndex");
        }

        //Admin (Araba onaylama)
        public ActionResult ToApprove(Car car)
        {
            cbm.CarTake = ca.Cars.Where(x => x.Approve == false).ToList();

            return View(cbm);
        }



        // GET: Admin (yorum listesi)
        public ActionResult CommentList()
        {
            var comments = ca.Comments.ToList();
            return View(comments);
        }

        // GET: Admin (yorum silme)
        public ActionResult DeleteComment(int id=0)
        {
            var deleteComment = ca.Comments.Find(id);
            ca.Comments.Remove(deleteComment);
            ca.SaveChanges();
            return RedirectToAction("CommentList");
        }

        // GET: Admin (yorum getir)
        public ActionResult GetComment(int id=0)
        {
            var comment = ca.Comments.Find(id);
            return View("GetComment", comment);
        }



        // GET: Admin (about listeleme)
        public ActionResult AboutList()
        {
            var abouts = ca.AboutUses.ToList();
            return View(abouts);
        }

        // GET: Admin (about ekleme)
        [HttpGet]
        public ActionResult NewAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAbout(AboutUs a)
        {
            ca.AboutUses.Add(a);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Admin (about silme)
        public ActionResult DeleteAbout(int id=0)
        {
            var findedAbout = ca.AboutUses.Find(id);
            ca.AboutUses.Remove(findedAbout);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Admin (about güncelleme)
        public ActionResult GetAbout(int id=0)
        {
            var findedAbout = ca.AboutUses.Find(id);
            return View("GetAbout", findedAbout);
        }
        public ActionResult UpdateAbout(AboutUs a)
        {
            var findedAbout2 = ca.AboutUses.Find(a.ID);
            findedAbout2.Description = a.Description;
            findedAbout2.FotoUrl = a.FotoUrl;
            findedAbout2.Title = a.Title;
            ca.SaveChanges();
            return RedirectToAction("Index");
        }



        // GET: Admin (contact listeleme)
        public ActionResult ContactList()
        {
            var contacts = ca.Contacts.ToList();
            return View(contacts);
        }

        // GET: Admin (contact silme)
        public ActionResult DeleteContact(int id=0)
        {
            var findedContact = ca.Contacts.Find(id);
            ca.Contacts.Remove(findedContact);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}