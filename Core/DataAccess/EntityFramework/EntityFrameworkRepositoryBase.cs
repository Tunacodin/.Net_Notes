using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EntityFrameworkRepositoryBase <TEntity,TContext> :IEntityRepository<IEntity>
     where TEntity : class, IEntity, new()  
     where TContext: DbContext,new()



    {


        public void Add(IEntity entity)
        {

            //using kullanmak Garbage Collector --- IDisposable işlemi ve performanslı
            using (TContext context = new TContext())
            {


                // referansı yakalar ve addedEntity referansı tutar
                var addedEntity = context.Entry(entity); // products entity değil context (db) tablo ismi, Entry=Products.Add
                //referanstaki tabloya ürünü ekler 
                addedEntity.State = EntityState.Added;
                //işlemi kaydeder ve veritabanına gönderir
                context.SaveChanges();
            }
        }



        public void Delete(IEntity entity)
        {

            using (TContext context = new TContext())
            {

                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public IEntity Get(Expression<Func<IEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<IEntity>().SingleOrDefault(filter);
            }
        }


        public List<IEntity> GetAll(Expression<Func<IEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<IEntity>().ToList()
                    : context.Set<IEntity>().Where(filter).ToList();
            }
        }



        public void Update(IEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
