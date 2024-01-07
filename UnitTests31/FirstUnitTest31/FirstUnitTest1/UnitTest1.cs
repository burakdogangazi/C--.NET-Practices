using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FirstUnitTest1
{//Arrange act assert
    [TestClass]
    public class UnitTest1
    {

        //Girilen ifadenin başındaki ve sonundaki fazla bosluklar silinmelidir.
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            var ifade = "          Burak Doğan        ";
            var beklenen = "Burak Doğan";

            //Act

            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);


            //Assert
            Assert.AreEqual(beklenen, gerceklesen);


        }
    }
}
