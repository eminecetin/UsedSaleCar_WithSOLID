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

        public ActionResult CarOwnerIndex(CarOwner co)
        {
            int carOwnerId = (int)Session["CarOwnerId"];
            cl.CarTake = ca.Cars.Where(x => x.CarOwner.ID == carOwnerId).ToList();
            return View(cl);
        }
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
            return RedirectToAction("CarOwnerIndex");
        }

        //sil
        public ActionResult DeleteCar(int id) 
        {
            var findedCar = ca.Cars.Find(id);
            ca.Cars.Remove(findedCar);
            ca.SaveChanges();
            return RedirectToAction("CarOwnerIndex");
        }

        //güncelle
        public ActionResult GetCar(int id)
        {
            var findedCar2 = ca.Cars.Find(id);
            return View("getCar", findedCar2);
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
            return RedirectToAction("CarOwnerIndex");
        }
    }
}