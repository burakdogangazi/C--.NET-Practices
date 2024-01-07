using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes41
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //Ownerlara göre grupluyor burağn metinin testleri diye ve yazanı söyler.
        [Owner("Burak")]
        [TestCategory("Tester")] // birden fazla kullanılabilir ve tester developer gruplanır.
        [Priority(1)] //önceliğine göre gruplanır uzun süren testte önceliği 1 olan testleri çalıştırmak için gruplar
        [TestProperty("Guncelleyen","Metin")]// guncelleyene göre gruplar kendi propertymiz tek methodda 2 tane olabilir farklı isimlerde olmalı
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Burak")]
        [TestCategory("Tester")]
        [TestCategory("Developer")]
        [Priority(1)]
        [TestProperty("Guncelleyen", "Metin")]
        [TestProperty("Guncelleyen2", "Metin")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Burak")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod]
        [Owner("Metin")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Metin")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }

        //2.video
        
        [TestMethod,Ignore] //İGNORE İLE TESTLERİ ATLAR
        public void TestMethod6()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod,Timeout(1000)]//metod 1 saniye üzerindeyse timeout girip fail olur.
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod,Ignore] //İGNORE İLE TESTLERİ ATLAR
        public void TestMethod8()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod,Timeout(TestTimeout.Infinite)] //SINIRSIZ OLUR
        public void TestMethod9()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod,Description("Bu bir karekök testi yapan metoddur")]// test metod adını açıklama şeklidne yapılabilir ama çok uzun olunca açıklama yazılabilir.
        public void TestMethod10()
        {
            Assert.AreEqual(1, 1);
        }

    }
}
