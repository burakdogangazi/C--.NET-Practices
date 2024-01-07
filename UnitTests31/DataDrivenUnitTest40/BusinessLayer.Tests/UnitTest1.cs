using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML"
            , "Kullanicilar.xml",//bulması için debug içinde arıyor bulması içinde bin debug içine gitmesi için xml dosyası sağ tık properties açıp always dedik
            "Kullanici",DataAccessMethod.Sequential)] //xml dosyasındaki her için çalışacak
        [TestMethod]
        public void DataTest() //xmlden test edip veri kontrolu
        {

            var manager = new KullaniciManager();

            var ad = TestContext.DataRow["ad"].ToString();
            var telefon = TestContext.DataRow["telefon"].ToString();
            var mail = TestContext.DataRow["mail"].ToString();



            var sonuc = manager.KullaniciEkle("ad", "telefon", "mail");
            Assert.IsTrue(sonuc);

            //Bütün xml dosyasındaki rowları alıp stringe çevirip teste soktuk testten çıkanları veritabanına ekleyebiliriz örnek olarak.

        }

        [DataSource("MyDataSource"),TestMethod]
        //MyDatasource kısmından data driven unit test 2 kısmında appconfig ayarlarından geliyor.
        public void DataTest2()//databaseden veri kontrolu
        {
            var manager = new IslemManager();

            //Her satırı veritabanından alıp teste tabir tuttuk.
            //xml config ayarları daha kolay ama veritabanı için appconfig daha zor.
            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int beklenen = Convert.ToInt32(TestContext.DataRow["beklenen"]);

            int gerceklesen = manager.Topla(x, y);

            Assert.AreEqual(beklenen, gerceklesen);

        }



    }
}
