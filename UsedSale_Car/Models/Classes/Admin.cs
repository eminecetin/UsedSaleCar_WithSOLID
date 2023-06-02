using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Admin : Users
    {
       

        public string AdminName { get; set; }  //private kullanıcı
        public bool Approve { get; set; }
        
    }
}