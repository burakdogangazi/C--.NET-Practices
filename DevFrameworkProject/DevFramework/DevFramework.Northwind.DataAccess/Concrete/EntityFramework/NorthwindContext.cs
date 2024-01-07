using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
            //yoksa üretmesin diye yani veritabaının kod tarafından üretilmesin migration yapmasın diye.
            //Hazır veritabanı kullanıyorum görmediğinde onu oluşturmaya çalışma
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        //Mapping Configrasyonun ayağa kaldırmak
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }

    }
}
