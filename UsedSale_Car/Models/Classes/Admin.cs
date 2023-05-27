using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Admin : Users, ILoginService, IAdvertOperation, IListingApproval
    {
        [Key]
        public int AdminID { get; set; }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void ApproveListing(string listingId)
        {
            throw new NotImplementedException();
        }

        public void Clear()
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

        public void RejectListing(string listingId)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}