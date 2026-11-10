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
    }
}
