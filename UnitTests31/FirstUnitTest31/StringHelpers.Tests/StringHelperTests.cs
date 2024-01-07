using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        

        [TestMethod]
        public void BasSonBosluklariSil()
        {

            //Arrange

            var ifade = "     BURAK DOĞAN    ";
            var beklenen = "BURAK DOĞAN";

            //Act
            var gerceklesen = StringHelpers.FazlaBosluklariSil(ifade);


            //Assert

              Assert.AreEqual(beklenen, gerceklesen);
        }

    }
}
