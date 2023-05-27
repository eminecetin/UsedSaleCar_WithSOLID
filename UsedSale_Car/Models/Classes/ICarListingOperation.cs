using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedSale_Car.Models.Classes
{
    interface ICarListingOperation
    {
        List<Car> GetCarListings();

        // Tüm vitrin ilanlarını döndürür
        // List<CarListing>: Vitrindeki ilanları içeren liste


        List<Car> FilterCarListings(string criteria);

        // Belirli bir kriterle vitrin ilanlarını filtreler ve sonuçları döndürür
        // criteria: Uygulanacak filtre kriterleri
        // List<CarListing>: Filtrelenmiş ilanları içeren liste
        //Diğer sınıftan liste halinde çekimler yapılması gerekiyor ve ona dikkat et!!
        //Plana sadık kal
        //Bunu her zaman için kendine hatırlat
        //Şimdi bu projeyi en ayrıntılı haliyle halledip sonrasında deniz hocanın stajyer öğrencisi olarak hem diğer öğrencilerde
        //hem de özellikle bursanın arasında o sorunu sağlaman a hgerekiyor.


        void SelectCarListing(string listingId);

        // Belirli bir ilana ait detayları gösterir
        // listingId: İlanın benzersiz kimliği
    }
}
