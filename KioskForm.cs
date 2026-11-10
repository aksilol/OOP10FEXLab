using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kiosk


{
    public partial class KioskForm : Form
    {
        public Cart myCart = new Cart();

        public KioskForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkout = new CheckoutForm(myCart,this);
            checkout.Show();

        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            myCart.AddItem(new Product
            {
                ProductID = 2,
                ProductName = "Burger",
                Price = 80
            });

        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            myCart.AddItem(new Product
            {
                ProductID = 3,
                ProductName = "Fries",
                Price = 45
            });
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            myCart.AddItem(new Product
            {
                ProductID = 1,
                ProductName = "Chicken",
                Price = 100
            });

        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            myCart.AddItem(new Product
            {
                ProductID = 4,
                ProductName = "Shawarma",
                Price = 120
            });

        }

        private void btnItem5_Click(object sender, EventArgs e)
        {
            myCart.AddItem(new Product
            {
                ProductID = 5,
                ProductName = "Biryani",
                Price = 90
            });
        }

        private void btnItem6_Click(object sender, EventArgs e)
        {
            myCart.AddItem(new Product
            {
                ProductID = 6,
                ProductName = "Kottu",
                Price = 60
            });
        }
    }
}
