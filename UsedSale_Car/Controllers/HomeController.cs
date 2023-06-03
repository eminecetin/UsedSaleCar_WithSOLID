using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using UsedSale_Car.Models.Classes;

namespace UsedSale_Car.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        CarListing cl = new CarListing();
        public ActionResult HomeIndex()
        {
            cl.CarTake = c.Cars.ToList().Take(3);
            cl.BrandTake = c.Brands.ToList();
            cl.AboutTake = c.AboutUses.ToList();
            cl.CommentTake = c.Comments.ToList().Take(6);
            var car = cl.BrandTake.FirstOrDefault();

            if (car != null)
            {
                var Id = car.ID; // Get the brandId from the car object

                var carListing = c.Models
                    .Include(i => i.Brand)
                    .Where(m => m.Brand.ID == Id)
                    .ToList();

                cl.ModelTake = carListing;
            }
            else
            {
                cl.ModelTake = new List<Model>(); // Or set it to an empty list if the car is not found
            }

            return View(cl);
        }

    }
}