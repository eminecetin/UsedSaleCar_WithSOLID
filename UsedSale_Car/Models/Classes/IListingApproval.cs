using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedSale_Car.Models.Classes
{
    interface IListingApproval
    {
        void ApproveListing(string listingId);

        // Belirli bir ilanı onaylar
        // listingId: İlanın benzersiz kimliği


        void RejectListing(string listingId);

        // Belirli bir ilanı reddeder
        // listingId: İlanın benzersiz kimliği
    }
}
