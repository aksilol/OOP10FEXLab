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
            CheckoutList = new ListBox();
            btnBack = new Button();
            btnAddItem = new Button();
            btnCheckout = new Button();
            btnRemoveItem = new Button();
            SuspendLayout();
            // 
            // CheckoutList
            // 
            CheckoutList.FormattingEnabled = true;
            CheckoutList.Location = new Point(9, 34);
            CheckoutList.Name = "CheckoutList";
            CheckoutList.Size = new Size(496, 349);
            CheckoutList.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(9, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 66);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back to Order";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(355, 401);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(150, 32);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
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
            btnRemoveItem.Location = new Point(355, 435);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(150, 32);
            btnRemoveItem.TabIndex = 4;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 504);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnCheckout);
            Controls.Add(btnAddItem);
            Controls.Add(btnBack);
            Controls.Add(CheckoutList);
            Name = "CheckoutForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox CheckoutList;
        private Button btnBack;
        private Button btnAddItem;
        private Button btnCheckout;
        private Button btnRemoveItem;
    }
}