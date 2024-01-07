using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;

        /*
         
         
         Testler method seviyesinde initialize ilk önce sonra metod 
        daha sonra cleanup çalışırken 
        ve her metod için baştan initialize ve test cleanup çalışır.

        class seviyesinde classinitialize bir kere çalışır ve classcleanup da bir kere çalışır ve methodlar sırayla girer.
        cleanup ve initialize static olmalıdır. ve initialize context almalıdır.
         
         */


        [ClassInitialize] 
        public static void ClassInitialize(TestContext testContext)
        {
            _cartManager = new CartManager();

            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500

                },

                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }


        [TestMethod]
        public void Sepette_farkli_urunden_1_adet_eklendiginde_toplamurunadadedi_elemansayisi_1_artmalidir()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;
            int topşamElemanSayisi = _cartManager.TotalItems;

            //Act
            

            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 20

                },

                Quantity = 1
            };

            //Assert
            Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(topşamElemanSayisi + 1, _cartManager.TotalItems);

        }
        

        [TestMethod]
        public void Sepette_olan_toplam_1_artmalı_elemansayisi_ayni_kalmali()
        {
            //Arrange
            int toplamAdet = _cartManager.TotalQuantity;
            int toplamElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Add(_cartItem);

            //Assert
            Assert.AreEqual(toplamAdet + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(toplamElemanSayisi, _cartManager.TotalItems); // burası testten geçemedi add kısmına metod ekledik

        }

        [ClassCleanup]//temizleme için test sonrası temizlemesi için
        public static void TestCleanup()
        {
            _cartManager.Clear();
        }
        

    }
}
