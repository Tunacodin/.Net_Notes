using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Entity lerle veritabanı tablolarını eşleştirdiğimiz context yapısı burasıdır. Bunu da DbContext sayedinde yaparız NuGet kullanrak
    public class NorthwindContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"(localdb)\MSSQLLocalDB, Database=Northwind,Trusted_Connection=true,TrustServerCertificate=True"); // localdb yerine IP adresi gelir

        }

        public DbSet<Product> Products {  get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; } 


    }
}
