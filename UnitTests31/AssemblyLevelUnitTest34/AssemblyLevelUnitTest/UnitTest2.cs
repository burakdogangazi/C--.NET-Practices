using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace AssemblyLevelUnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running unittest2 class ini");
        }
        [ClassCleanup]
        public static void ClassCleanup(TestContext testContext)
        {
            Debug.WriteLine("Running unittest2 class clean");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running unittest2 test ini"); 
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running unittest2 test clean");
        }


        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("Running TestMethod3");
        }
        [TestMethod]
        public void TestMethod4()
        {
            Debug.WriteLine("Running TestMethod4");
        }
    }
}
