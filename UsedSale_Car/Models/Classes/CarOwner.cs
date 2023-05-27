using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class CarOwner:Users, ICarListingOperation, ICarComparison, ILoginService
    {
        [Key]
        public int CarOwnerID { get; set; }
        private string UserName { get; set; }
        private string Pasword { get; set; }

        public string UserName_
        {
            get { return UserName; }
            set { UserName = value; }
        }
        public string Pasword_
        {
            get { return Pasword; }
            set { Pasword = value; }
        }

        public List<Car> GetCarListings()
        {
            throw new NotImplementedException();
        }

        public List<Car> FilterCarListings(string criteria)
        {
            throw new NotImplementedException();
        }

        public void SelectCarListing(string listingId)
        {
            throw new NotImplementedException();
        }

        public void CompareVehicles(string vehicleId1, string vehicleId2)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}