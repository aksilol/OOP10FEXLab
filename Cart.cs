using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;
using System.Linq;

namespace Kiosk
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }
            = new List<CartItem>();

        public void AddItem(Product product)
        {
            var existing = Items.FirstOrDefault(
                x => x.Product.ProductID == product.ProductID
            );

            if (existing != null)
            {
                existing.Quantity++;
            }
            else
            {
                Items.Add(new CartItem
                {
                    Product = product,
                    Quantity = 1
                });
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.Subtotal);
        }

        public void RemoveItem(int productID)
        {
            Items.RemoveAll(
                x => x.Product.ProductID == productID
            );
        }
    }
}
