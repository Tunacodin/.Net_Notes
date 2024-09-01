using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Burası İŞ KATMANININ somut class ı
    public class ProductManager:IProductService
    {
        // İş kodları
        // Eğer istekler bu katmandan başarılı bir şekilde geçerse ancak o zaman DataAccess katmanındaki verilere başarılı bir şekilde erişim sağlanabilir

        // Bir class başka bir classı new'leyemez o yüzden code injection yapıyoruz

        IProductDal  _productDal;

        public ProductManager(IProductDal productDal)
        {
           _productDal = productDal;
        }

        public List<Product> GetAll()
        {

            return _productDal.GetAll();    
        }

      

    


    }
}
