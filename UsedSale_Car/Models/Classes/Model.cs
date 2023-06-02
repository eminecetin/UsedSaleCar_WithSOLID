using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Model
    {
        [Key]
        public int ID { get; set; }
        public int BrandID { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
        public virtual Brand Brand { get; set; }

    }
}