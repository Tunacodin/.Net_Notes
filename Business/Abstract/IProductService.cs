
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entities.Concrete; // Product'a erişmek için Entities katmanını bağladık
namespace Business.Abstract
{

    // Merhaba burası İŞ KATMANI. Veri Erişim katmanındaki bilgilere erişmek için burada bir takım işlemler yapılmak zorundadır

    public interface IProductService
    {
        List<Product> GetAll();


    }
}
