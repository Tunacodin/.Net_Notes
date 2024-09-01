
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using DataAccess.Abstract;  //  IProductDal
using Entities.Concrete;    //  public void Add(Product product) 


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;        // Bütün metotların dışında tanımlanan referans tutan değişken bellekte bir liste tutar. Naming convention denir _name şeklinde yazılır
                                        // Bu listenin oluşması için çağrıldığı yerde new'lenmesi gerekir. Bunu sağlayan da constructor'dır


        public InMemoryProductDal()
        {
            _products = new List<Product>
        }
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

       
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
