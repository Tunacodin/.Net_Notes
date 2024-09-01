using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{

    // ICategoryDal , IProductDal yerine artık burayı kullanacağız ve değiken tiplerini de generic olarak vereceğiz


    public interface IEntityRepository<T> where T : class,IEntity, new() // Generic olarak verilecek tipte bu özellikler olmalı ve hepsini sağlamalı

    {
        T Get(Expression<Func<T,bool>> filter);
        //                 --------------- LINQ ---------------
        List<T> GetAll(Expression<Func<T, bool>> filter = null);// Expression<Func<T,bool>> bu sayede filtreleme işlemi yapabiliyor olacağız
                                                                //categoryId==2, fiyat 0-300 arası, productName="TV"
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
