using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kiosk
{
    public partial class CheckoutForm : Form
    {

        private Cart cart;
        private KioskForm kiosk;

        public CheckoutForm(Cart myCart, KioskForm form)
        {
            InitializeComponent();

            cart = myCart;
            kiosk = form;

            DisplayCart();
        }
        private void DisplayCart()
        {
            lstCart.Items.Clear();

            foreach (var item in cart.Items)
            {
                lstCart.Items.Add(
                    item.Product.ProductName +
                    " x " + item.Quantity +
                    " - ₱" + item.Subtotal
                );
            }

            lblTotal.Text = "Total: ₱" + cart.GetTotal();
        }

        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            cart.RemoveLastItem();

            DisplayCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty!");
                return;
            }

            // Create new order
            Order newOrder = new Order();

            newOrder.OrderID = QueueStore.NextOrderNumber;
            newOrder.OrderNumber = "A" +
                QueueStore.NextOrderNumber.ToString("000");

            newOrder.OrderDate = DateTime.Now;

            newOrder.Status = OrderStatus.Preparing;

            newOrder.TotalAmount = cart.GetTotal();

            // Copy cart items into the order
            foreach (var item in cart.Items)
            {
                newOrder.Items.Add(new OrderItem
                {
                    ProductName = item.Product.ProductName,
                    Price = item.Product.Price,
                    Quantity = item.Quantity
                });
            }

            // Save order to shared queue
            QueueStore.Orders.Add(newOrder);

            QueueStore.NextOrderNumber++;

            // Clear cart after successful submission
            cart.Clear();

            // Open Queue form
            Queue queue = new Queue();
            queue.Show();

            // Close CheckoutForm
            this.Close();
        }
    }
}
