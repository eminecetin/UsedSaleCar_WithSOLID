using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class AboutUs
    {
        [Key]
        public int ID { get; set; }
        public string Goals { get; set; }
        public string Work { get; set; }
        public string Passion { get; set; }
    }
}