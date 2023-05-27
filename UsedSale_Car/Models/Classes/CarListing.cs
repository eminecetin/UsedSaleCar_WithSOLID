using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class CarListing
    {
        public IEnumerable<Car> CarTake { get; set; }
        public IEnumerable<Brands> BrandTake { get; set; }
        public IEnumerable<Models> ModelTake { get; set; }
        public IEnumerable<CarOwner> CarOwnerTake { get; set; }
        public IEnumerable<CarType> CarTypeTake { get; set; }
        public IEnumerable<Color> ColorTake { get; set; }
        public IEnumerable<City> CityTake { get; set; }
        public IEnumerable<Users> UserTake { get; set; }
        public IEnumerable<Comment> CommentTake { get; set; }
        public IEnumerable<AboutUs> AboutTake { get; set; }
    }
}