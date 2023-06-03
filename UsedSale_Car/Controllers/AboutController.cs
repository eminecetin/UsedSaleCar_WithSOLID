using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsedSale_Car.Models.Classes;

namespace UsedSale_Car.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context c = new Context();
        public ActionResult AboutIndex()
        {
            var degerler = c.AboutUses.ToList();
            return View(degerler);
        }
        public ActionResult AboutDetail(int id=0)
        {
            var d = c.AboutUses.Where(a => a.ID ==id).ToList();
            return View(d);
        }

    }
}