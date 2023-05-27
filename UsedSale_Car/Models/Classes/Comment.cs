using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string eMail { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        public int CarID { get; set; }

    }
}