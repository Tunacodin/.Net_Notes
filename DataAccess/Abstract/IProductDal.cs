using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entities.Concrete; // DataAccess Entities katmanını çağırır (Artık Core katmanından çağırıyor)
                         //Code refactoring yapıldı


namespace Core.DataAccess
{

    // Product tablosunu(class) implemente eden veri erişim katmanıdır
    // Inteface içerisindeki metotların başına public yazılmaz
    public interface IProductDal : IEntityRepository<Product>

    {
            

       
    }
}
