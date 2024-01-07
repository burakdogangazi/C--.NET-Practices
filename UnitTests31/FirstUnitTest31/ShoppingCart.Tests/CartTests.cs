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

        public void Sepete_urun_eklenebilmelidir()
        {
            //Arrange

            const int beklenen = 1;

            var cartManager = new CartManager();

            var cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500

                },

                Quantity = 1
            };

            //Act

            cartManager.Add(cartItem);

            var toplamElemanSayisi = cartManager.TotalItems;

            Assert.AreEqual(beklenen, toplamElemanSayisi);

        }

        public void Sepetten_urun_cıkarilabilmelidir()
        {
            //Arrange


            var cartManager = new CartManager();

            var cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500

                },

                Quantity = 1
            };


            cartManager.Add(cartItem);

            var sepetteOlanElemanSayisi = cartManager.TotalItems;

            //Act
            cartManager.Remove(1);
            var sepetteKalanElemanSayisi = cartManager.TotalItems;

            //Assert
            Assert.AreEqual(sepetteOlanElemanSayisi - 1, sepetteKalanElemanSayisi);
        }

        public void Sepete_temizlenebilmelidir()
        {
            //Arrange

            

            var cartManager = new CartManager();

            var cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500

                },

                Quantity = 1
            };

            //Act

            cartManager.Clear();

            //Assert
            Assert.AreEqual(0, cartManager.TotalQuantity);
            Assert.AreEqual(0, cartManager.TotalItems);
           
        }









    }
}
