using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double girilenDeger = 16;
            const double beklenen = 4;
            double gerceklesen = Math.Sqrt(girilenDeger);

            Assert.AreEqual(beklenen, gerceklesen, "{0} sayısının karekökü {1} olmalıdır", girilenDeger, beklenen); ;
            //test fail oluca yazı ekranda görünür message alır
        }

        [TestMethod]
        public void TestMethod2()
        {
            double delta = 0.0001;
            double beklenen = 3.1622;
            double gercek = Math.Sqrt(10);
            //|beklenen-gerceklesen| <=delta doğru ise geçerlidir.
            Assert.AreEqual(beklenen, gercek,delta); //delta testin geçmesini hata marjını söyler. 
        }
        [TestMethod]
        public void TestMethod3()
        {
            string beklenen = "MERHABA";
            string gerceklesen = "merhaba";
            //ignore case özelliği var küçük büyük duyarsız çalışması içni true
            Assert.AreEqual(beklenen, gerceklesen,true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            const double beklenmeyen = 0;
            var gerceklesen = Math.Pow(5, 0);
            Assert.AreNotEqual(beklenmeyen, gerceklesen); // sonuç 1 test geçerli
        }

        [TestMethod]
        public void TestMethod5()
        {

            var sayilar = new byte[] { 1, 2, 3 };
            var digerSayilar = sayilar;
            sayilar[0] = 4;

            Assert.AreSame(sayilar, digerSayilar);
            //Referans tipli oldukları için true döndü sayilar adresler aynı oldu değişikler birbirini etkiler
        }

        [TestMethod]
        public void TestMethod6()
        {
            int a = 10;
            int b = a;

            Assert.AreEqual(a, b,"AreEqual failed"); //true
            Assert.AreSame(a, b, "AreSame failed"); // false
            
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Bu test yeterli değildir");
            //Test başarılı ama yeterli değildir.

        }

        [TestMethod]
        public void TestMethod8()
        {
            var sayi = 5m;

            Assert.IsInstanceOfType(sayi, typeof(decimal));//true
            Assert.IsNotInstanceOfType(sayi, typeof(int));//true

        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);//true
            Assert.IsFalse(10 % 2 == 0);//false testten geçer

        }

        [TestMethod]
        public void TestMethod10()
        {

            List<string> sayilar = new List<string> { "Salih", "Engin", "Ahmet" };

            var cIleBaslayanIlkIsım = sayilar.FirstOrDefault(t => t.StartsWith("C"));

            var sIleBaslayanIlkIsım = sayilar.FirstOrDefault(t => t.StartsWith("S"));

            Assert.IsNull(cIleBaslayanIlkIsım, "Isnull başarısız");
            Assert.IsNotNull(sIleBaslayanIlkIsım, "ISnot null başarısız");

        }

        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var sayi = 5;
                int sonuc = sayi / 0;
            }

            catch (DivideByZeroException)
            {
                Assert.Fail("Test başarısız oldu.");
            }

           
        }














    }
}
