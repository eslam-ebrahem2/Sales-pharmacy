namespace Sales.PL
    {
    partial class productFrm
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
            if (disposing && ( components != null ))
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
            DGVproduct = new DataGridView();
            texName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            texByPrice = new TextBox();
            label3 = new Label();
            texSalePrice = new TextBox();
            label4 = new Label();
            texQty = new TextBox();
            label5 = new Label();
            comboCategory = new ComboBox();
            butAdd = new Button();
            butUpdate = new Button();
            butDelete = new Button();
            groupBox1 = new GroupBox();
            radioById = new RadioButton();
            radioByName = new RadioButton();
            texSearch = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ( (System.ComponentModel.ISupportInitialize)DGVproduct ).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGVproduct
            // 
            DGVproduct.AllowUserToAddRows = false;
            DGVproduct.AllowUserToDeleteRows = false;
            DGVproduct.Anchor =    AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            DGVproduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVproduct.Location = new Point(0, 218);
            DGVproduct.Name = "DGVproduct";
            DGVproduct.ReadOnly = true;
            DGVproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVproduct.Size = new Size(926, 294);
            DGVproduct.TabIndex = 0;
            DGVproduct.CellMouseClick +=  DGVproduct_CellMouseClick ;
            // 
            // texName
            // 
            texName.Location = new Point(51, 55);
            texName.MaxLength = 20;
            texName.Name = "texName";
            texName.Size = new Size(187, 23);
            texName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            label1.AutoSize = true;
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            label2.AutoSize = true;
            label2.Location = new Point(272, 37);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "By Price";
            // 
            // texByPrice
            // 
            texByPrice.Location = new Point(272, 55);
            texByPrice.MaxLength = 10;
            texByPrice.Name = "texByPrice";
            texByPrice.Size = new Size(84, 23);
            texByPrice.TabIndex = 3;
            texByPrice.KeyPress +=  texByPrice_KeyPress ;
            // 
            // label3
            // 
            label3.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            label3.AutoSize = true;
            label3.Location = new Point(382, 37);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Sale Price";
            // 
            // texSalePrice
            // 
            texSalePrice.Location = new Point(382, 55);
            texSalePrice.Name = "texSalePrice";
            texSalePrice.Size = new Size(84, 23);
            texSalePrice.TabIndex = 5;
            texSalePrice.KeyPress +=  texSalePrice_KeyPress ;
            // 
            // label4
            // 
            label4.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            label4.AutoSize = true;
            label4.Location = new Point(502, 37);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // texQty
            // 
            texQty.Location = new Point(502, 55);
            texQty.Name = "texQty";
            texQty.Size = new Size(105, 23);
            texQty.TabIndex = 7;
            texQty.KeyPress +=  texQty_KeyPress ;
            // 
            // label5
            // 
            label5.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            label5.AutoSize = true;
            label5.Location = new Point(634, 37);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Category";
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(634, 55);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(121, 23);
            comboCategory.TabIndex = 10;
            // 
            // butAdd
            // 
            butAdd.BackColor = Color.MediumSeaGreen;
            butAdd.FlatStyle = FlatStyle.Flat;
            butAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            butAdd.ForeColor = Color.White;
            butAdd.Location = new Point(3, 3);
            butAdd.Name = "butAdd";
            butAdd.Padding = new Padding(10);
            butAdd.Size = new Size(154, 50);
            butAdd.TabIndex = 11;
            butAdd.Text = "Add New Product";
            butAdd.UseVisualStyleBackColor = false;
            butAdd.Click +=  butAdd_Click ;
            // 
            // butUpdate
            // 
            butUpdate.BackColor = Color.DarkTurquoise;
            butUpdate.FlatStyle = FlatStyle.Flat;
            butUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            butUpdate.ForeColor = Color.White;
            butUpdate.Location = new Point(218, 3);
            butUpdate.Name = "butUpdate";
            butUpdate.Padding = new Padding(10);
            butUpdate.Size = new Size(154, 50);
            butUpdate.TabIndex = 12;
            butUpdate.Text = "Update Product";
            butUpdate.UseVisualStyleBackColor = false;
            butUpdate.Click +=  butUpdate_Click ;
            // 
            // butDelete
            // 
            butDelete.BackColor = Color.Crimson;
            butDelete.FlatStyle = FlatStyle.Flat;
            butDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            butDelete.ForeColor = Color.White;
            butDelete.Location = new Point(433, 3);
            butDelete.Name = "butDelete";
            butDelete.Padding = new Padding(10);
            butDelete.Size = new Size(154, 50);
            butDelete.TabIndex = 13;
            butDelete.Text = "Delete Product";
            butDelete.UseVisualStyleBackColor = false;
            butDelete.Click +=  butDelete_Click ;
            // 
            // groupBox1
            // 
            groupBox1.Anchor =  AnchorStyles.Top  |  AnchorStyles.Right ;
            groupBox1.Controls.Add(radioById);
            groupBox1.Controls.Add(radioByName);
            groupBox1.Controls.Add(texSearch);
            groupBox1.Location = new Point(663, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // radioById
            // 
            radioById.AutoSize = true;
            radioById.Location = new Point(139, 63);
            radioById.Name = "radioById";
            radioById.Size = new Size(55, 19);
            radioById.TabIndex = 17;
            radioById.Text = "By ID";
            radioById.UseVisualStyleBackColor = true;
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(21, 63);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(75, 19);
            radioByName.TabIndex = 16;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // texSearch
            // 
            texSearch.Location = new Point(6, 32);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(226, 23);
            texSearch.TabIndex = 15;
            texSearch.TextAlign = HorizontalAlignment.Center;
            texSearch.TextChanged +=  texSearch_TextChanged ;
            texSearch.KeyPress +=  texSearch_KeyPress ;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(comboCategory);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(texQty);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(texSalePrice);
            panel1.Controls.Add(texName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(texByPrice);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 220);
            panel1.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor =   AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(butAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(butUpdate, 1, 0);
            tableLayoutPanel1.Controls.Add(butDelete, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 156);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(645, 56);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // productFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 512);
            Controls.Add(DGVproduct);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "productFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            WindowState = FormWindowState.Maximized;
            Load +=  productFrm_Load ;
            ( (System.ComponentModel.ISupportInitialize)DGVproduct ).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private DataGridView DGVproduct;
        private TextBox texName;
        private Label label1;
        private Label label2;
        private TextBox texByPrice;
        private Label label3;
        private TextBox texSalePrice;
        private Label label4;
        private TextBox texQty;
        private Label label5;
        private ComboBox comboCategory;
        private Button butAdd;
        private Button butUpdate;
        private Button butDelete;
        private GroupBox groupBox1;
        private RadioButton radioById;
        private RadioButton radioByName;
        private TextBox texSearch;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        }
    }