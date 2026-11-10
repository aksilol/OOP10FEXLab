namespace Kiosk
{
    partial class Queue
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lstNowServing = new ListView();
            lstPreparing = new ListView();
            btnSave = new Button();
            btnBack = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(24, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1135, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(570, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 100);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 33);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 1;
            label2.Text = "READY";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 33);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 0;
            label1.Text = "PREPARING";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lstNowServing
            // 
            lstNowServing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstNowServing.Location = new Point(594, 142);
            lstNowServing.Name = "lstNowServing";
            lstNowServing.Size = new Size(561, 330);
            lstNowServing.TabIndex = 3;
            lstNowServing.UseCompatibleStateImageBehavior = false;
            lstNowServing.View = View.List;
            // 
            // lstPreparing
            // 
            lstPreparing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPreparing.Location = new Point(24, 142);
            lstPreparing.Name = "lstPreparing";
            lstPreparing.Size = new Size(561, 330);
            lstPreparing.TabIndex = 4;
            lstPreparing.UseCompatibleStateImageBehavior = false;
            lstPreparing.View = View.List;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1010, 486);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save to Text File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(858, 486);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 37);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Queue
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1179, 711);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(lstPreparing);
            Controls.Add(lstNowServing);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(900, 600);
            Name = "Queue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queue";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ListView listView1;
        private ListView lstPreparing;
        private Button btnSave;
        private Button btnBack;
        public ListView lstNowServing;
    }
}