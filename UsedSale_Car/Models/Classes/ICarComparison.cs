using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedSale_Car.Models.Classes
{
    interface ICarComparison
    {
        void CompareVehicles(string vehicleId1, string vehicleId2);

        // İki aracı karşılaştırır ve sonuçları gösterir
        // vehicleId1: Karşılaştırılacak birinci aracın kimliği
        // vehicleId2: Karşılaştırılacak ikinci aracın kimliği
    }
}
