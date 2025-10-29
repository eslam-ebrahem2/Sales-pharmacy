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
        private void InitializeComponent()
            {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CID = new DataGridViewTextBoxColumn();
            CName = new DataGridViewTextBoxColumn();
            TXcategory = new TextBox();
            label2 = new Label();
            ButAdd = new Button();
            TXsearch = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            butEdit = new Button();
            butDelete = new Button();
            SearchTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)dataGridView1 ).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CID, CName });
            dataGridView1.Location = new Point(492, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(353, 517);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellMouseClick +=  dataGridView1_CellMouseClick ;
            // 
            // CID
            // 
            CID.DataPropertyName = "ID";
            CID.HeaderText = "Category ID";
            CID.Name = "CID";
            CID.ReadOnly = true;
            // 
            // CName
            // 
            CName.DataPropertyName = "NAME";
            CName.HeaderText = "Category Name";
            CName.Name = "CName";
            CName.ReadOnly = true;
            // 
            // TXcategory
            // 
            TXcategory.Font = new Font("Segoe UI", 15F);
            TXcategory.Location = new Point(22, 50);
            TXcategory.Name = "TXcategory";
            TXcategory.Size = new Size(247, 34);
            TXcategory.TabIndex = 3;
            TXcategory.KeyPress +=  TXcategory_KeyPress ;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(22, 19);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 4;
            label2.Text = "Category Name";
            // 
            // ButAdd
            // 
            ButAdd.BackColor = SystemColors.Highlight;
            ButAdd.FlatStyle = FlatStyle.Flat;
            ButAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButAdd.ForeColor = Color.White;
            ButAdd.Location = new Point(22, 90);
            ButAdd.Name = "ButAdd";
            ButAdd.Size = new Size(165, 47);
            ButAdd.TabIndex = 5;
            ButAdd.Text = "Add Category";
            ButAdd.UseVisualStyleBackColor = false;
            ButAdd.Click +=  ButAdd_Click ;
            // 
            // TXsearch
            // 
            TXsearch.Font = new Font("Segoe UI", 15F);
            TXsearch.Location = new Point(15, 22);
            TXsearch.Name = "TXsearch";
            TXsearch.Size = new Size(188, 34);
            TXsearch.TabIndex = 6;
            TXsearch.TextChanged +=  TXsearch_TextChanged ;
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
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TXcategory);
            groupBox2.Controls.Add(ButAdd);
            groupBox2.Location = new Point(12, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 148);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add new category";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(butEdit);
            groupBox3.Controls.Add(butDelete);
            groupBox3.Location = new Point(12, 303);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(288, 94);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delete coustom category";
            // 
            // butEdit
            // 
            butEdit.BackColor = Color.LimeGreen;
            butEdit.Enabled = false;
            butEdit.FlatStyle = FlatStyle.Flat;
            butEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            butEdit.ForeColor = Color.White;
            butEdit.Location = new Point(113, 41);
            butEdit.Name = "butEdit";
            butEdit.Size = new Size(92, 27);
            butEdit.TabIndex = 1;
            butEdit.Text = "Edit";
            butEdit.UseVisualStyleBackColor = false;
            butEdit.Click +=  butEdit_Click ;
            // 
            // butDelete
            // 
            butDelete.BackColor = Color.Red;
            butDelete.Enabled = false;
            butDelete.FlatStyle = FlatStyle.Flat;
            butDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            butDelete.ForeColor = Color.White;
            butDelete.Location = new Point(15, 41);
            butDelete.Name = "butDelete";
            butDelete.Size = new Size(92, 27);
            butDelete.TabIndex = 0;
            butDelete.Text = "Delete ";
            butDelete.UseVisualStyleBackColor = false;
            butDelete.Click +=  butDelete_Click ;
            // 
            // SearchTimer
            // 
            SearchTimer.Interval = 1000;
            SearchTimer.Tick +=  SearchTimer_Tick ;
            // 
            // categoryFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 554);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "categoryFrm";
            Text = "Category";
            Load +=  categoryFrm_Load ;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)dataGridView1 ).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
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
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button butDelete;
        private DataGridViewTextBoxColumn CID;
        private DataGridViewTextBoxColumn CName;
        private Button butEdit;
        private System.Windows.Forms.Timer SearchTimer;
        }
    }