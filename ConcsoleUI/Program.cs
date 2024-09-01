using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConcsoleUI
{ 
    class Program
{

    static void Main(string[] args)
    {
            IProductDal productDal= new EntityFrameworkProductDal();

            ProductManager productManager = new ProductManager(productDal);

            foreach(var product in productManager.GetAll())
            {
                Console.WriteLine("Product Name : " + product.ProductName);
            }
    }
}
}
