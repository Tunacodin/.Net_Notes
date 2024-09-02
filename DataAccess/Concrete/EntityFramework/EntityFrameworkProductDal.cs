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

    //ÖNEMLİ!! Dikkat ettiysen categoryDal customerDal ile burası neredeyse tamamen aynı ,
    //sadece northwindcontex yani db değişebilir ya da entity ismi değişebilir
    public class EntityFrameworkProductDal : IProductDal

    {

       
    }
}
