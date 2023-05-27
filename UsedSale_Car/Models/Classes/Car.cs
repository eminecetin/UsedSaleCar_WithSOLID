using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Car
    {
        [Key]
        public int VehicleID { get; set; }
        public CarType CarType { get; set; }
        public int TypeID { get; set; }
        public DateTime UretimYili { get; set; }
        public int Doors { get; set; }
        public int BrandID { get; set; }
        public Brands Brands { get; set; }
        public Models Models { get; set; }
        public int ModelsID { get; set; }
        public string Power { get; set; }
        public string Fuel { get; set; }
        public string EngineSize { get; set; }
        public int NumberOfSeats { get; set; }
        public int Price { get; set; }
        public string MileAge { get; set; }
        public string Image { get; set; }
        public bool FogLight { get; set; }
        public bool UsedOrNew { get; set; }
        public bool GlassSeiling { get; set; }
        public bool ParkingSensor { get; set; }
        public bool CentralLocking { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }
}