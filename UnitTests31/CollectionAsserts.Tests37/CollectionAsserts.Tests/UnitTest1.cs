using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _kullanicilar;

        [TestInitialize]
        public void DataOlustur()
        {
            _kullanicilar = new List<string>();

            _kullanicilar.Add("Salih");
            _kullanicilar.Add("Engin");
            _kullanicilar.Add("Ahmet");


        }

        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();

            yeniKullanicilar.Add("Salih");
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Ahmet");

            CollectionAssert.AreEqual(_kullanicilar, yeniKullanicilar);
            //hata verir elemanlar ve sırası aynı olmalıdır çünkü sıraları aynı değil testinitiailze ile

        }


        [TestMethod]
        public void Elemanlar_aynı_fakat_sırası_farklı_olabilir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Salih");
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Ahmet");

            CollectionAssert.AreEquivalent(_kullanicilar, yeniKullanicilar);
            //sırası farklı olabilir ama verilerin eşit olması gerekiyor areequiavlent
            //true testten geçer
        }


        [TestMethod]
        public void Elemanlar_vesirasi_ayni_olmammalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Salih");
            yeniKullanicilar.Add("Ahmet");

            CollectionAssert.AreNotEqual(_kullanicilar, yeniKullanicilar);
            //farklı durum olması yeterli sırası ya da değerinin değişik olması yeterlidir.
        }
        [TestMethod]
        public void Elemanlar_farkli_olmalidir()
        {
            List<string> yeniKullanicilar = new List<string>();
            yeniKullanicilar.Add("Salih");
            yeniKullanicilar.Add("Engin");
            yeniKullanicilar.Add("Ahmet");
            yeniKullanicilar.Add("Mustafa");

            CollectionAssert.AreNotEquivalent(_kullanicilar, yeniKullanicilar);
            
            //Bu testten geçebilmesi için sırasının farklı olması yetmez değerde farklı olmalıdır.
        }

        [TestMethod]
        public void Kullanicilar_null_deger_almamalidir()
        {
            CollectionAssert.AllItemsAreNotNull(_kullanicilar);
        }

        [TestMethod]
        public void Kullanicilar_benzersiz_olmalidir()
        {
            CollectionAssert.AllItemsAreUnique(_kullanicilar);
        }

        [TestMethod]
        public void Tüm_elemanlar_Aynı_tipte_olmalidir()
        {
            /*
             En belirgin iki farkı vardır. İlki Array homojen elementlerin toplamıyken List heterojen elementlerin toplamıdır. İkincisi ise bellekte Array için ayrılan alan sabit ve sürekliyken List için ayrılan alan dinamik ve rastgeledir.*/
            ArrayList liste = new ArrayList
            {
                "Salih","Engin","Ahmet"
            };

            CollectionAssert.AllItemsAreInstancesOfType(liste,typeof(string));
        }

        [TestMethod]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullanicilar = new List<string> { "Salih", "Engin" };
            List<string> eskiKullanicilar = new List<string> { "Salih", "Cevdet" };

            CollectionAssert.IsSubsetOf(yeniKullanicilar, _kullanicilar);
            CollectionAssert.IsNotSubsetOf(eskiKullanicilar, _kullanicilar); // atl küme testi
        }


        [TestMethod]
        public void Contains_test()
        {
            CollectionAssert.Contains(_kullanicilar, "Salih");
            CollectionAssert.DoesNotContain(_kullanicilar, "Cevat");

        }


    }
}
