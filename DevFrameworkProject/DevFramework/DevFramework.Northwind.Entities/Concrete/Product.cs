using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Entities.Concrete
{
    public class Product:IEntity
    {
        //Veritabanından bütün cloulmnları tek tek çekmemek için
        //devart ,ef powertools , generator yazılabilir
        //devart 10 nesneye kadar ücretsiz.

        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public object CategoryName { get; set; }
        //Virtual nhibernate orm istiyor diye ef de ses çıkarmıyor
    }
}
