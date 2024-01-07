using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Entities;

namespace WebApiDemo.DataAccess
{
    public class NorthwindContext: DbContext
    {
        //Entity Framework Core ve entitiframework.core.sqlserver
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}
