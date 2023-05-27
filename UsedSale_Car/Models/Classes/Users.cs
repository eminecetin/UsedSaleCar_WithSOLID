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
        private string Name;
        private string Surname;
        private string eMail;

        public string Name_
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Surname_
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public string Email
        {
            get { return eMail; }
            set { eMail = value; }
        }
       
    }
}