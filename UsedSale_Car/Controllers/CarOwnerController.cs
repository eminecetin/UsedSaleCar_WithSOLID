using UsedSale_Car.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsedSale_Car.Controllers
{
    public class CarOwnerController : Controller
    {
        Context ca = new Context();
        CarListing cl = new CarListing();


        // GET: CarOwner
        [Authorize]
        public ActionResult CarOwnerIndex()
        {
            string lastName = Session["LastName"] as string;
            string firstName = Session["FirstName"] as string;
            string mail = Session["Mail"] as string;
            string phone = Session["Phone"] as string;
            string password = Session["Password"] as string;
            int id = 0;

            if (Session["ID"] != null && int.TryParse(Session["ID"].ToString(), out int parsedId))
            {
                id = parsedId;
            }

            //id si eşleşen arabalar gelsin

            // View'a kullanıcı bilgilerini taşımak
            // cbm.ValueCar = ca.Cars.Where(i => i.CarOwner.LastName== lastName).ToString(); 
            ViewBag.LastName = lastName;
            ViewBag.FirstName = firstName;
            ViewBag.Mail = mail;
            ViewBag.Phone = phone;
            ViewBag.Password = password;
            ViewBag.ID = id;
            cl.CarTake = ca.Cars.Where(x => x.CarOwner.ID == id).ToList();
            return View(cl);
        }

        // GET: CarOwner (araba ekleme)
        [HttpGet]
        public ActionResult NewCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewCar(Car c)
        {
            //Kullanıcı bilgilerini Session'dan almak
            string lastName = Session["LastName"] as string;
            string firstName = Session["FirstName"] as string;
            string mail = Session["Mail"] as string;
            string phone = Session["Phone"] as string;
            string password = Session["Password"] as string;
            int id = (int)Session["ID"];
            ca.CarOwners.Where(i => i.ID == id).
                Where(i => i.FirstName == firstName).
                Where(i => i.LastName == lastName).
                Where(i => i.Phone == phone).
                Where(i => i.Password == password).
                Where(i => i.Mail == mail).ToList();

            ViewBag.owner = ca.Cars.Where(i => i.CarOwner.ID == id).ToList();

            c.Approve = false;

            ca.Cars.Add(c);
            ca.SaveChanges();
            return RedirectToAction("CarOwnerIndex");
            //if (null != ca.CarOwners.Where( i=>i.Mail==c.CarOwnerMail))
            //{
            //    ca.SaveChanges();
            //    return RedirectToAction("CarOwnerIndex");

            //}
            //else { return RedirectToAction("NewCar"); }

        }

        // GET: CarOwner (araba silme)
        public ActionResult DeleteCar(int id=0)
        {
            var findedCar = ca.Cars.Find(id);
            ca.Cars.Remove(findedCar);
            ca.SaveChanges();
            return RedirectToAction("CarOwnerIndex");
        }

        // GET: CarOwner (araba güncelleme)
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
            findedCar3.CarOwner.Mail = c.CarOwner.Mail;
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
            return RedirectToAction("CarOwnerIndex");
        }
    }
}