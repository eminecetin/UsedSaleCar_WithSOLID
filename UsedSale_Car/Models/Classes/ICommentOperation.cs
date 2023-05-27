using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedSale_Car.Models.Classes
{
    interface ICommentOperation
    {
        void AddComment(string listingId, string comment);

        // İlgili ilana yeni bir yorum ekler
        // listingId: İlanın benzersiz kimliği
        // comment: Eklenen yorum metni


        List<string> GetComments(string listingId);

        // İlgili ilana ait tüm yorumları döndürür
        // listingId: İlanın benzersiz kimliği
        // List<string>: İlanın yorumlarını içeren liste


        void DeleteComment(string listingId, string commentId);

        // İlgili ilanın belirli bir yorumunu siler
        // listingId: İlanın benzersiz kimliği
        // commentId: Silinecek yorumun benzersiz kimliği

        void AddComment(Comment comment);
        void DeleteComment(int commentId);
        void UpdateComment(Comment comment);
    }
}
