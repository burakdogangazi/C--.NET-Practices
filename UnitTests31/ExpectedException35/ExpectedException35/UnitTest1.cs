using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExpectedException35
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Shopping cart aynısı sadece cartmanager eğer sepete eklenmişsse ürün sepette var diye hata veriyor throw new ArgumentException atıyor
            //[ExpectedException(typeof(ArgumentException)] yazdık testmethod altına hata vermedi çünkü beklediğimiz test
            //Exception yazınca testten geçmesi beklenir ama birebir exception olmadığı için kabul olmaz olması için AllowderivedTypes = true yaparsak sorun düzelir
        }
    }
}
