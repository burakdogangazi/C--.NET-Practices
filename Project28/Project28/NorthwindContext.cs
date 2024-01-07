using Project28.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project28
{ // veritabanı ve uygulamayı bindlamak için kurduk ve proje üzerinde manage nuget package ile entitty framework yükledik.
    public class NorthwindContext:DbContext
    {

        //Hangi nesne hangi veritabanında neye bağlandığını söylememiz lazım

        public DbSet<Product> Products { get; set; } // Product Tablosu ile products veritabanını bağladık










    }
}
