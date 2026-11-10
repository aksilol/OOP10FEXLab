using System;
using System.Collections.Generic;
using System.Text;

namespace Kiosk
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string ImagePath { get; set; }
    }
}