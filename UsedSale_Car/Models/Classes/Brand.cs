using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }

    }
}