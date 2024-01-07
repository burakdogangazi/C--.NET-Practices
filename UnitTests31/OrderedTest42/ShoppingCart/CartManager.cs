
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartManager
    {

        /*
         
        1. Sepette ürün eklenebilmelidir.
        2. Sepette olan ürün çıkarılabilmelidir.
        3. Sepet Temizlenebilmelidir.

        4. Sepette olan üründen 1 adet eklendiğinde sepetteki toplam ürün adedi bir artmalı eleman sayısı aynı kalmalıdır.
        5. Sepette farklı üründen 1 adet eklendiğinde sepetteki toplam ürün adedi ve eleman sayısı bir artmalıdır.


         */


        private readonly List<CartItem> _cartItems;

        public CartManager()
        {
            _cartItems = new List<CartItem>();
        }


        public void Add(CartItem cartItem)
        {
            var cartItem1 = _cartItems.SingleOrDefault(t => t.Product.ProductId == cartItem.Product.ProductId);

            if (cartItem1 == null)
            {
                _cartItems.Add(cartItem);
            }

            else
            {
                cartItem1.Quantity += cartItem.Quantity;
            }

        }


        public void Remove(int productId)
        {
            var product = _cartItems.FirstOrDefault(p => p.Product.ProductId == productId);
            _cartItems.Remove(product);
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public void Clear()
        {
            _cartItems.Clear();
        }

        public decimal TotalPrice
        {
            get
            {
                return _cartItems.Sum(p => p.Quantity * p.Product.UnitPrice);
            }
        }

        public int TotalQuantity
        {
            get
            {
                return _cartItems.Sum(t => t.Quantity);
            }
        }

        public int TotalItems
        {
            get
            {
                return _cartItems.Count;
            }
        }
    }
}
