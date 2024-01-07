using Northwind.Entities.Concrete;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccsess.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductDal
    {

        public List<Product> GetAll()
        {
            using(NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Products.SingleOrDefault(p =>p.ProductId == id)
            }
        }

        public void Add(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                northwindContext.Products.Add(product);
                northwindContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                //northwindContext.Products.Add(product);
                northwindContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                //northwindContext.Products.Add(product);
                northwindContext.SaveChanges();
            }
        }

    }
}
