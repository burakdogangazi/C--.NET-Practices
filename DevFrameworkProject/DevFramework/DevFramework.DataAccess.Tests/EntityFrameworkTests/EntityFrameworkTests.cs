using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {

            EfProductDal productDal = new EfProductDal();
            //normal şartlarda kullanılmaz. ıoc container kullanılır.

            var result = productDal.GetList();

            Assert.AreEqual(77, result.Count); 
            // veritabanından veri çekebilmesi için app.config dosyası ekleyip bağlantıyı sağladık.
            //Entity framework bu test dizinine manage nuget packages ile ekledik
            //Testten geçer
            // 77 sayısı product veritabanındaki toplam ürün sayısı Select COUNT(*) as NumberOfP from Products

        }

        [TestMethod]
        public void Get_all_with_paramater_returns_filtered_products()
        {

            EfProductDal productDal = new EfProductDal();
            //normal şartlarda kullanılmaz. ıoc container kullanılır.

            var result = productDal.GetList(p =>p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
            // veritabanından veri çekebilmesi için app.config dosyası ekleyip bağlantıyı sağladık.
            //Entity framework bu test dizinine manage nuget packages ile ekledik
            //Testten geçer
            //Select Count(*) from products where ProductName like '%ab%' içinde ab geçen ürün sayısı
        }
    }
}
