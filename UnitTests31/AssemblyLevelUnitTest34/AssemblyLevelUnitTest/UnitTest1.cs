using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AssemblyLevelUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Ne kadar class olursa olsun 1 tane assemblyinitialize ve assemblycleanup olur hangi class da olduğunun önemi yok
        // bir test class içinde 1 tane class ve test initialize cleanup olabilir
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running initial");
        }
        
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running clean");
        }
        
        [TestInitialize]
        public static void ClassIntitialize(TestContext testContext)
        {
            Debug.WriteLine("Running initial class");
        }

        [TestCleanup]

        public static void ClassCleanup()
        {
            Debug.WriteLine("Running initial cleanup");
        }

        [TestInitialize]
        public  void TestInitialize()
        {
            Debug.WriteLine("Running test initialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running test cleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Running testmethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("Running testmethod2");
        }

    }
    //Assembly
    //class initial
    //test initial sırasıyla çalışır 1 kere çalışırlar hepsi

}

