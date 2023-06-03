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
        CarListing cl = new CarListing();
        // GET: Admin

        [Authorize]
        public ActionResult AdminIndex()
        {
            cl.CarTake = ca.Cars.Where(x => x.Approve == true).ToList();
            return View(cl);
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
        public ActionResult GetCar(int id)
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
            cl.CarTake = ca.Cars.Where(x => x.Approve == false).ToList();

            return View(cl);
        }

        //[HttpGet]
        //public ActionResult NewToApprove()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult NewToApprove(Car c)
        //{
        //    ca.Cars.Add(c);
        //    ca.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //// GET: Admin (onay güncelleme)
        //public ActionResult GetApprove(int id)
        //{
        //    var findedCar2 = ca.Cars.Find(id);
        //    return View("GetApprove", findedCar2);
        //}

        //public ActionResult UpdateApprove(Car c)
        //{
        //    var findedCar3 = ca.Cars.Find(c.ID);
        //    findedCar3.Approve = c.Approve;
        //    ca.SaveChanges();
        //    return RedirectToAction("ToApprove");
        //}



        // GET: Admin (yorum listesi)
        public ActionResult CommentList()
        {
            var comments = ca.Comments.ToList();
            return View(comments);
        }

        // GET: Admin (yorum silme)
        public ActionResult DeleteComment(int id)
        {
            var deleteComment = ca.Comments.Find(id);
            ca.Comments.Remove(deleteComment);
            ca.SaveChanges();
            return RedirectToAction("CommentList");
        }

        // GET: Admin (yorum getir)
        public ActionResult GetComment(int id)
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
        public ActionResult DeleteAbout(int id)
        {
            var findedAbout = ca.AboutUses.Find(id);
            ca.AboutUses.Remove(findedAbout);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Admin (about güncelleme)
        public ActionResult GetAbout(int id)
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
       
        public ActionResult DeleteContact(int id)
        {
            var findedContact = ca.Contacts.Find(id);
            ca.Contacts.Remove(findedContact);
            ca.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}