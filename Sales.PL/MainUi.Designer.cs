namespace Sales.PL
{
    partial class MainUi
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
            BT_CATEGORY = new Button();
            BT_PRODUCT = new Button();
            BT_STOCK = new Button();
            BT_REPORTS = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            BT_SELL = new Button();
            ( (System.ComponentModel.ISupportInitialize)pictureBox1 ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)pictureBox2 ).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_CATEGORY
            // 
            BT_CATEGORY.BackColor = Color.FromArgb(255, 128, 128);
            BT_CATEGORY.FlatStyle = FlatStyle.Flat;
            BT_CATEGORY.ForeColor = Color.AliceBlue;
            BT_CATEGORY.Location = new Point(3, 91);
            BT_CATEGORY.Name = "BT_CATEGORY";
            BT_CATEGORY.Size = new Size(180, 57);
            BT_CATEGORY.TabIndex = 0;
            BT_CATEGORY.Text = "CATEGORES";
            BT_CATEGORY.UseVisualStyleBackColor = false;
            BT_CATEGORY.Click +=  BT_CATEGORY_Click ;
            // 
            // BT_PRODUCT
            // 
            BT_PRODUCT.BackColor = Color.FromArgb(255, 128, 128);
            BT_PRODUCT.FlatStyle = FlatStyle.Flat;
            BT_PRODUCT.ForeColor = Color.AliceBlue;
            BT_PRODUCT.Location = new Point(3, 177);
            BT_PRODUCT.Name = "BT_PRODUCT";
            BT_PRODUCT.Size = new Size(180, 57);
            BT_PRODUCT.TabIndex = 1;
            BT_PRODUCT.Text = "PRODUCTS";
            BT_PRODUCT.UseVisualStyleBackColor = false;
            // 
            // BT_STOCK
            // 
            BT_STOCK.BackColor = Color.FromArgb(255, 128, 128);
            BT_STOCK.FlatStyle = FlatStyle.Flat;
            BT_STOCK.ForeColor = Color.AliceBlue;
            BT_STOCK.Location = new Point(3, 272);
            BT_STOCK.Name = "BT_STOCK";
            BT_STOCK.Size = new Size(180, 57);
            BT_STOCK.TabIndex = 2;
            BT_STOCK.Text = "STOCK";
            BT_STOCK.UseVisualStyleBackColor = false;
            // 
            // BT_REPORTS
            // 
            BT_REPORTS.BackColor = Color.FromArgb(255, 128, 128);
            BT_REPORTS.FlatStyle = FlatStyle.Flat;
            BT_REPORTS.ForeColor = Color.AliceBlue;
            BT_REPORTS.Location = new Point(3, 365);
            BT_REPORTS.Name = "BT_REPORTS";
            BT_REPORTS.Size = new Size(180, 57);
            BT_REPORTS.TabIndex = 3;
            BT_REPORTS.Text = "REPORTS";
            BT_REPORTS.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.symbol_4;
            pictureBox1.Location = new Point(824, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.symbol_4;
            pictureBox2.Location = new Point(425, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 238);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(BT_PRODUCT);
            panel1.Controls.Add(BT_CATEGORY);
            panel1.Controls.Add(BT_STOCK);
            panel1.Controls.Add(BT_REPORTS);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 506);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(263, 331);
            label1.Name = "label1";
            label1.Size = new Size(519, 54);
            label1.TabIndex = 7;
            label1.Text = "PHARMACY MANGEMENT";
            // 
            // BT_SELL
            // 
            BT_SELL.FlatAppearance.MouseDownBackColor = Color.Cyan;
            BT_SELL.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            BT_SELL.FlatStyle = FlatStyle.Flat;
            BT_SELL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BT_SELL.ForeColor = SystemColors.ControlDarkDark;
            BT_SELL.Location = new Point(375, 401);
            BT_SELL.Name = "BT_SELL";
            BT_SELL.Size = new Size(264, 93);
            BT_SELL.TabIndex = 8;
            BT_SELL.Text = "NEW INVOICE";
            BT_SELL.UseVisualStyleBackColor = true;
            // 
            // MainUi
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(863, 506);
            Controls.Add(BT_SELL);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "MainUi";
            Text = "Form1";
            ( (System.ComponentModel.ISupportInitialize)pictureBox1 ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)pictureBox2 ).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Button BT_CATEGORY;
        private Button BT_PRODUCT;
        private Button BT_STOCK;
        private Button BT_REPORTS;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private Button BT_SELL;
        }
}
