using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())// using kullanmadan  idrek ifadeyi içeri yazarsan metod bitince garbage collector çöpe atar
            {// using kullnarak belleğin atmasını beklemeden direk kendimiz atıyoruz dispose etmek

                return context.Products.ToList();//veritabınındaki erişme kodu
                // list çevirdiğimiz için aynı tür oluyor
            }

        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())

                return context.Products.Where(p => p.Name.Contains(key)).ToList();

        }

        public List<Product> GetUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())

                return context.Products.Where(p => p.UnitPrice >= price).ToList();

        }

        public List<Product> GetByUnitPrice(decimal max, decimal min)
        {
            using (ETradeContext context = new ETradeContext())

                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <=max).ToList();

        }

        /*public List<Product> GetById()
        {
            using (ETradeContext context = new ETradeContext())

                var result = context.Products.FirstOrDefault(p => p.Id == id);
            return result; //single or default aynı datadan 3 tane gelirse fln hata verir first ilk bulduğunu alır
        }*/

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {

                context.Products.Add(product);
                context.SaveChanges();
            };
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {

                var entity = context.Entry(product);// veritabanındaki ile bizim yazdığımızı eşitler
                entity.State = EntityState.Modified; // aynısını added da yapılabilir
                context.SaveChanges();
            };
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {

                var entity = context.Entry(product);// veritabanındaki ile bizim yazdığımızı eşitler
                entity.State = EntityState.Deleted; // aynısını added da yapılabilir
                context.SaveChanges();
            };
        }
    }
}
