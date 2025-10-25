namespace Sales.PL
    {
    partial class categoryFrm
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
        private void InitializeComponent() {
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            TXcategory = new TextBox();
            label2 = new Label();
            ButAdd = new Button();
            TXsearch = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)dataGridView1 ).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 37);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(354, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 1;
            label1.Text = "Categores";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(845, 356);
            dataGridView1.TabIndex = 2;
            // 
            // TXcategory
            // 
            TXcategory.Font = new Font("Segoe UI", 15F);
            TXcategory.Location = new Point(157, 53);
            TXcategory.Name = "TXcategory";
            TXcategory.Size = new Size(264, 34);
            TXcategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 4;
            label2.Text = "Category Name";
            // 
            // ButAdd
            // 
            ButAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButAdd.Location = new Point(157, 93);
            ButAdd.Name = "ButAdd";
            ButAdd.Size = new Size(264, 47);
            ButAdd.TabIndex = 5;
            ButAdd.Text = "Add Category";
            ButAdd.UseVisualStyleBackColor = true;
            ButAdd.Click +=  ButAdd_Click ;
            // 
            // TXsearch
            // 
            TXsearch.Font = new Font("Segoe UI", 15F);
            TXsearch.Location = new Point(15, 22);
            TXsearch.Name = "TXsearch";
            TXsearch.Size = new Size(188, 34);
            TXsearch.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(15, 59);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 7;
            label3.Text = "Serach by Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TXsearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(545, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // categoryFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 517);
            Controls.Add(groupBox1);
            Controls.Add(ButAdd);
            Controls.Add(label2);
            Controls.Add(TXcategory);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "categoryFrm";
            Text = "categoryFrm";
            Load +=  categoryFrm_Load ;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)dataGridView1 ).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox TXcategory;
        private Label label2;
        private Button ButAdd;
        private TextBox TXsearch;
        private Label label3;
        private GroupBox groupBox1;
        }
    }