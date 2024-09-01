
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
                                       
        //_products aslında bütün ürünleri tutan bir liste bunu unutma



        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1, CategoryId=1, ProductName="TV", UnitPrice=10, UnitsInStock=12 },

            };
        }



        public List<Product> GetAll()
        {

            // ürün listesini döndürür

            return _products;

         

        }


        public void Add(Product product)
        {
             _products.Add( product);
        }

        public void Delete(Product product)
        {
            Product productToDelete; // Geçici bir değişken oluşturduk 

            // foreach döngüsü kullanmak yerine SingleOrDefault() fonksiyonu kullanmak bir LINQ işlemidir

            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // _products listesindeki "p" elemanlarının id değeri ile fonksiyon ile gönderilen product değerinin id'sine eşit olan ürünü seçer

            _products.Remove(productToDelete);  // seçilen bu ürünü listeden kaldırır, yani product tablosundan siler


        }

       
        public void Update(Product product)
        {
            Product productToUpdate; // Geçici bir değişken oluşturduk 

            // foreach döngüsü kullanmak yerine SingleOrDefault() fonksiyonu kullanmak bir LINQ işlemidir

            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // _products listesindeki "p" elemanlarının id değeri ile fonksiyon ile gönderilen product değerinin id'sine eşit olan ürünü seçer

            productToUpdate.ProductName=product.ProductName;
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitsInStock=product.UnitsInStock;


          


        }

        public List<Product> GetAllById(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); // _products listesinde kategori id si istenilen id ye eşit olan ürünleri bul ve bunları bir listeye çevir


        }
    }
}
