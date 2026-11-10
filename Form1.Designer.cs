namespace Kiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            btnItem1 = new Button();
            btnItem6 = new Button();
            btnItem2 = new Button();
            btnItem5 = new Button();
            btnItem3 = new Button();
            btnItem4 = new Button();
            btnAddCart = new Button();
            btnCheckout = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(22, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 512);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Order";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnItem1);
            panel1.Controls.Add(btnItem6);
            panel1.Controls.Add(btnItem2);
            panel1.Controls.Add(btnItem5);
            panel1.Controls.Add(btnItem3);
            panel1.Controls.Add(btnItem4);
            panel1.Location = new Point(6, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 487);
            panel1.TabIndex = 6;
            // 
            // btnItem1
            // 
            btnItem1.Location = new Point(27, 9);
            btnItem1.Name = "btnItem1";
            btnItem1.Size = new Size(237, 175);
            btnItem1.TabIndex = 0;
            btnItem1.Text = "-";
            btnItem1.UseVisualStyleBackColor = true;
            // 
            // btnItem6
            // 
            btnItem6.Location = new Point(350, 400);
            btnItem6.Name = "btnItem6";
            btnItem6.Size = new Size(237, 175);
            btnItem6.TabIndex = 5;
            btnItem6.Text = "-";
            btnItem6.UseVisualStyleBackColor = true;
            // 
            // btnItem2
            // 
            btnItem2.Location = new Point(350, 9);
            btnItem2.Name = "btnItem2";
            btnItem2.Size = new Size(237, 175);
            btnItem2.TabIndex = 1;
            btnItem2.Text = "-";
            btnItem2.UseVisualStyleBackColor = true;
            // 
            // btnItem5
            // 
            btnItem5.Location = new Point(27, 400);
            btnItem5.Name = "btnItem5";
            btnItem5.Size = new Size(237, 175);
            btnItem5.TabIndex = 4;
            btnItem5.Text = "-";
            btnItem5.UseVisualStyleBackColor = true;
            // 
            // btnItem3
            // 
            btnItem3.Location = new Point(27, 204);
            btnItem3.Name = "btnItem3";
            btnItem3.Size = new Size(237, 175);
            btnItem3.TabIndex = 2;
            btnItem3.Text = "-";
            btnItem3.UseVisualStyleBackColor = true;
            // 
            // btnItem4
            // 
            btnItem4.Location = new Point(350, 204);
            btnItem4.Name = "btnItem4";
            btnItem4.Size = new Size(237, 175);
            btnItem4.TabIndex = 3;
            btnItem4.Text = "-";
            btnItem4.UseVisualStyleBackColor = true;
            // 
            // btnAddCart
            // 
            btnAddCart.Location = new Point(74, 575);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(179, 57);
            btnAddCart.TabIndex = 2;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(411, 575);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(179, 57);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 635);
            Controls.Add(btnCheckout);
            Controls.Add(btnAddCart);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button btnItem1;
        private Button btnItem6;
        private Button btnItem2;
        private Button btnItem5;
        private Button btnItem3;
        private Button btnItem4;
        private Button btnAddCart;
        private Button btnCheckout;
    }
}
