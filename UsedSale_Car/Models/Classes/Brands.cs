using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Brands
    {
        [Key]
        public int ID { get; set; }
        public int MyProperty { get; set; }
        public CarType TypeID { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public ICollection<Car> Cars { get; set; }

    }
}