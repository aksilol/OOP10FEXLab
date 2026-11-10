using System.Collections.Generic;
using System.Linq;

namespace Kiosk
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }
            = new List<CartItem>();

        private Stack<int> additionHistory = new Stack<int>();

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

            additionHistory.Push(product.ProductID);
        }

        public void RemoveLastItem()
        {
            if (additionHistory.Count == 0)
                return;

            int lastID = additionHistory.Pop();

            var item = Items.FirstOrDefault(
                x => x.Product.ProductID == lastID
            );

            if (item != null)
            {
                item.Quantity--;

                if (item.Quantity <= 0)
                {
                    Items.Remove(item);
                }
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.Subtotal);
        }

        public void Clear()
        {
            Items.Clear();
            additionHistory.Clear();
        }
    }
}