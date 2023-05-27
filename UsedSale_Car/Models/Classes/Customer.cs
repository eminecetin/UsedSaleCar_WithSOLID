using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public class Customer:Users,ICommentOperation, IAdvertOperation, ICarListingOperation
    {
        [Key]
        public int CustomerId { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void AddComment(string listingId, string comment)
        {
            throw new NotImplementedException();
        }

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(string listingId, string commentId)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public List<Car> FilterCarListings(string criteria)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarListings()
        {
            throw new NotImplementedException();
        }

        public List<string> GetComments(string listingId)
        {
            throw new NotImplementedException();
        }

        public void SelectCarListing(string listingId)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}