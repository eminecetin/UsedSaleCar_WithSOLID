using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedSale_Car.Models.Classes
{
    interface ILoginService
    {
        bool Login(string username, string password);
        void Logout();
    }
}
