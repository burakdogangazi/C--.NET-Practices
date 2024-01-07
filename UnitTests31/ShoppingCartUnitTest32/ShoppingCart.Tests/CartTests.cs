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
        private CartItem _cartItem;
        private CartManager _cartManager;

        /*
         
         
         Testler method seviyesinde initialize ilk önce sonra metod 
        daha sonra cleanup çalışırken 
        ve her metod için baştan initialize ve test cleanup çalışır.
         
         */


        [TestInitialize] // ilk önce bu çalışır herkesde ortak olan metodlarda
        public void TestInitialize()
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
        public void Sepete_urun_eklenebilmelidir()
        {
            //Arrange

            const int beklenen = 1;
            
            //Act
            var toplamElemanSayisi = _cartManager.TotalItems;

            Assert.AreEqual(beklenen, toplamElemanSayisi);

        }

        [TestMethod]
        public void Sepetten_urun_cıkarilabilmelidir()
        {
            //Arrange

            var sepetteOlanElemanSayisi = _cartManager.TotalItems;

            //Act
            _cartManager.Remove(1);
            var sepetteKalanElemanSayisi = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(sepetteOlanElemanSayisi - 1, sepetteKalanElemanSayisi);
        }
        
        [TestCleanup]//temizleme için test sonrası temizlemesi için
        public void TestCleanup()
        {
            _cartManager.Clear();
        }


        [TestMethod]
        public void Sepete_temizlenebilmelidir()
        {
            //Act

            _cartManager.Clear();

            //Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);

        }

    }
}
