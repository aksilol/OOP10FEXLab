using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal Subtotal
        {
            get { return Product.Price * Quantity; }
        }
    }
}