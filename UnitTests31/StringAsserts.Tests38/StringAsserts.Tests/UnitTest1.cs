using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Test dünyasından merhaba", "yas");

        }
        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("Test dünyasında merhaba", new Regex(@"[a-zA-z]"));//by patern geçerliyse başarılı
            StringAssert.DoesNotMatch("Test dünyasından merhaba", new Regex(@"[0-9]"));
        }

        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Test dünyasından merhaba", "Test");// küçük büyük duyarlı
        }

        [TestMethod]
        public void EndssWithTest()
        {
            StringAssert.EndsWith("Test dünyasından merhaba", "merhaba");// küçük büyük duyarlı
        }



    }
}
