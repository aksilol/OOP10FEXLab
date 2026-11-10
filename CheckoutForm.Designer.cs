namespace Kiosk
{
    partial class CheckoutForm
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCart = new ListBox();
            btnBack = new Button();
            btnCheckout = new Button();
            btnRemoveItem = new Button();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lstCart
            // 
            lstCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCart.FormattingEnabled = true;
            lstCart.Location = new Point(9, 34);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(496, 340);
            lstCart.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 66);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back to Order";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(187, 401);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(150, 66);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(355, 401);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(150, 66);
            btnRemoveItem.TabIndex = 4;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 349);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(23, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "₱";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 504);
            Controls.Add(lblTotal);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnCheckout);
            Controls.Add(btnBack);
            Controls.Add(lstCart);
            Name = "CheckoutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCart;
        private Button btnBack;
        private Button btnCheckout;
        private Button btnRemoveItem;
        private Label lblTotal;
    }
}