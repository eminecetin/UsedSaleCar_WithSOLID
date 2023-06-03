using UsedSale_Car.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace UsedSale_Car.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        Context c = new Context();
        CarListing cl = new CarListing();

        public ActionResult CarIndex()
        {

            cl.CarTake = c.Cars.Include(i => i.Brand).Include(i => i.Model).Where(i => i.Approve == true).ToList();
            cl.BrandTake = c.Brands.ToList();
            cl.ModelTake = c.Models.ToList();
            cl.ColorTake = c.Colors.ToList();
            cl.CarOwnerTake = c.CarOwners.ToList();
            cl.CarTypeTake = c.CarTypes.ToList();
            return View(cl);
        }

        public ActionResult CarDetail(int id)
        {
            cl.CarTake = c.Cars.Where(a => a.ID == id)
                .Include(i => i.Brand)
                .Include(i => i.Model)
                .Include(i => i.Color)
                .Include(i => i.CarOwner)
                .Include(i => i.CarType).ToList();

            cl.CommentTake = c.Comments.Where(a => a.CarId == id).ToList();
            var car = cl.CarTake.FirstOrDefault();

            if (car != null)
            {
                var Id = car.Brand.ID; // Get the brandId from the car object

                var modelsByBrand = c.Models
                    .Include(i => i.Brand)
                    .Where(m => m.Brand.ID == Id)
                    .ToList();

                cl.ModelTake = modelsByBrand;
            }
            else
            {
                cl.ModelTake = new List<Model>(); // Or set it to an empty list if the car is not found
            }

            return View(cl);
        }

        [HttpGet]
        public PartialViewResult ToComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ToComment(Comment co)
        {
            c.Comments.Add(co);
            c.SaveChanges();
            return PartialView();
        }
    }
}