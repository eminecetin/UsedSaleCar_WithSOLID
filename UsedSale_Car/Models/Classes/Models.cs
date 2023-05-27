using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Models
    {
        [Key]
        public int ID { get; set; }
        public Brands BrandsId { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public ICollection<Car> Car { get; set; }

    }
}