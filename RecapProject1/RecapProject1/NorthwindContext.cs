using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{// veri tabanı ile nesnemizi birbirlerine bind eder bağlar
    public class NorthwindContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
