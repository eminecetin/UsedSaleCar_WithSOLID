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
        public int ID { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string Description { get; set; }
        public string PhotoCarURL { get; set; }
        public int Doors { get; set; }
        public bool FogLights { get; set; } //sis farı
        public bool FoldableMirror { get; set; } //katlanabilir ayna
        public bool ParkingSensor { get; set; }
        public bool CentralLocking { get; set; } //merkezi kilit
        public bool GlassCeiling { get; set; } //cam tavan

        public bool Approve { get; set; }
        public DateTime PublicationDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public virtual Model Model { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual City City { get; set; }
        public virtual Color Color { get; set; }
        public virtual CarType CarType { get; set; }
        public virtual CarOwner CarOwner { get; set; }

    }
}