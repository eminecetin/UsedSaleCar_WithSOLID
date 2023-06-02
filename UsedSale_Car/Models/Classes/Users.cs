using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedSale_Car.Models.Classes
{
    public abstract class Users
    {
        [Key]
        public int ID { get; set; }
        public string Phone { get; set; }
        private string Name;
        private string Surname;
        private string eMail;
        private string Pasword;
        public string FirstName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string LastName
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public string Mail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public string Password
        {
            get { return Pasword; }
            set { Pasword = value; }
        }


    }
}