
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entities.Concrete; // DataAccess Entities katmanını çağırır



namespace DataAccess.Abstract
{

    // Product tablosunu(class) implemente eden veri erişim katmanıdır
    // Inteface içerisindeki metotların başına public yazılmaz
    public interface IProductDal
    {
             List<Product> GetAll();

           
            void Add(Product product);

            void Delete(Product product);

            void Update (Product product);

       
    }
}
