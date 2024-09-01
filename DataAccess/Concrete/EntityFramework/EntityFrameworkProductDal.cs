using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EntityFrameworkProductDal : IProductDal

    {
        public void Add(Product entity)
        {

            //using kullanmak Garbage Collector --- IDisposable işlemi ve performanslı
            using (NorthwindContext context = new NorthwindContext()) {
                

                // referansı yakalar ve addedEntity referansı tutar
                var addedEntity=context.Entry(entity); // products entity değil context (db) tablo ismi, Entry=Products.Add
                //referanstaki tabloya ürünü ekler 
                addedEntity.State=EntityState.Added;
                //işlemi kaydeder ve veritabanına gönderir
                context.SaveChanges();
            }
        }

     

        public void Delete(Product entity)
        {

            using (NorthwindContext context = new NorthwindContext()) {

                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext()) {
            return context.Set<Product>().SingleOrDefault(filter);
            }
        }


        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext()) {
                return filter == null 
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

     

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) { 
            var updatedEntity = context.Entry(entity);
                updatedEntity.State=EntityState.Modified;
                context.SaveChanges();
            }
        }

       
    }
}
