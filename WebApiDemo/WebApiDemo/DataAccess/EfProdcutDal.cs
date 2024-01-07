using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApiDemo.Entities;
using WebApiDemo.Models;

namespace WebApiDemo.DataAccess
{
    public class EfProdcutDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductModel> GetProductWithDetails()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var result = from p in northwindContext.Products
                             join c in northwindContext.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductModel { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };
                return result.ToList();
            }
        }
    }
}
