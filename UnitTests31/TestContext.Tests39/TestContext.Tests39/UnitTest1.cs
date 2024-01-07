using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextDemo.Tests39
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void TestInitialize()
        {

            TestContext.WriteLine("--Testİnitialize--"); //test sonucu output oluşturur
            TestContext.WriteLine("Test Adı : {0}", TestContext.TestName);
            TestContext.WriteLine("Test durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.Properties["bilgi"] = "Bu bir bilgidir";

        }
        [TestCleanup]
        public void TestCleanup()
        {

            TestContext.WriteLine("--TestCleanup--"); //test sonucu output oluşturur
            TestContext.WriteLine("Test Adı : {0}", TestContext.TestName);
            TestContext.WriteLine("Test durumu : {0}", TestContext.CurrentTestOutcome);


        }


        [TestMethod]
        public void TestMethod1()
        {

            TestContext.WriteLine("--Testmethod1--"); //test sonucu output oluşturur
            TestContext.WriteLine("Test Adı : {0}", TestContext.TestName);
            TestContext.WriteLine("Test durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test sınıfı : {0}", TestContext.FullyQualifiedTestClassName);

            Assert.AreEqual(1, 1);

        }
    }
}
