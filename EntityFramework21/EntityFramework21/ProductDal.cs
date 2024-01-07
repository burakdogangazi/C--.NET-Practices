using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework21
{
    public class ProductDal
    {

        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext()) // context açılınca bağlantı için app config bakacaktır.
            {//kullanmayınca işi bitince garbage collector ile hafızadan siler

                return context.Products.ToList();

            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext()) // context açılınca bağlantı için app config bakacaktır.
            {//kullanmayınca işi bitince garbage collector ile hafızadan siler

                return context.Products.Where(p=>p.Name.Contains(key)).ToList();

            }
        }

        public List<Product> GetUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext()) // context açılınca bağlantı için app config bakacaktır.
            {//kullanmayınca işi bitince garbage collector ile hafızadan siler

                return context.Products.Where(p => p.UnitPrice>=price).ToList();
                //veri tabanına sql sorgusunu atıyor.
            }
        }


        public List<Product> GetUnitPriceMaxMin(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext()) // context açılınca bağlantı için app config bakacaktır.
            {//kullanmayınca işi bitince garbage collector ile hafızadan siler

                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();
                //veri tabanına sql sorgusunu atıyor.
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext()) // context açılınca bağlantı için app config bakacaktır.
            {//kullanmayınca işi bitince garbage collector ile hafızadan siler

                return context.Products.FirstOrDefault(p => p.Id == id);
                //ilk bulduğunu getir bulamazsan null getir.
                //single or Default da kullanılabilir bu kayda uyan birden fazla ürün varsa hata verir.



            }
        }



        public void Add(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);// bizim product ile veri tabanındakini eşitler
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }


        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);// bizim product ile veri tabanındakini eşitler
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }



    }
}
