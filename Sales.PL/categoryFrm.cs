using Sales.BLL.servces;
using Sales.DAL.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales.PL
    {
    public partial class categoryFrm : Form
        {
        public categoryFrm()
            {
            InitializeComponent();
            }

        private void ButAdd_Click(object sender, EventArgs e)
            {

            if (string.IsNullOrEmpty(TXcategory.Text))
                {
                MessageBox.Show("please add category name", "error", MessageBoxButtons.OK);
                return;
                }
            Category Cat = new Category()
                {
                Name = TXcategory.Text

                };

            bool isAdd = CategoryService.addCategory(Cat);
            if (isAdd)
                {
                MessageBox.Show("add sucsess", "sucsess", MessageBoxButtons.OK);
                fillDG();
                }
            else
                {
                MessageBox.Show("erorr adding ", "error", MessageBoxButtons.OK);
                }

            }
        //----------------------------------------------------------------
        private void categoryFrm_Load(object sender, EventArgs e)
            {

            fillDG();
            }

        //----------------------------------------------------------------
        private void fillDG()
            {
            List<Category> catlist = CategoryService.getallCategory();
            dataGridView1.DataSource = catlist;
            TXcategory.Text = "";
            TXsearch.Text = "";
            }



        private void butDelete_Click(object sender, EventArgs e)
            {
            int idSelected = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString() ?? "");
            bool sucsess = CategoryService.deleteCategoryById(idSelected);

            if (sucsess)
                { fillDG(); }
            else
                { MessageBox.Show("error deleting", "", MessageBoxButtons.OK); }
            }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
            butDelete.Enabled = true;
            butEdit.Enabled = true;
            string nameSelected = dataGridView1.CurrentRow.Cells[1].Value.ToString() ?? "";
            TXcategory.Text = nameSelected;
            }

        private void butEdit_Click(object sender, EventArgs e)
            {
            int idSelected = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString() ?? "");
            string nameSelected = dataGridView1.CurrentRow.Cells[1].Value.ToString() ?? "";
            bool sucsess = CategoryService.editCategoryById(idSelected, nameSelected);

            if (sucsess)
                { fillDG(); }
            else
                { MessageBox.Show("error deleting", "", MessageBoxButtons.OK); }
            }



        private void TXcategory_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (e.KeyChar == (char)Keys.Enter)
                {

                if (string.IsNullOrEmpty(TXcategory.Text))
                    {
                    MessageBox.Show("please add category name", "error", MessageBoxButtons.OK);
                    return;
                    }
                Category Cat = new Category()
                    {
                    Name = TXcategory.Text

                    };

                bool isAdd = CategoryService.addCategory(Cat);
                if (isAdd)
                    {
                    MessageBox.Show("add sucsess", "sucsess", MessageBoxButtons.OK);
                    fillDG();
                    }
                else
                    {
                    MessageBox.Show("erorr adding ", "error", MessageBoxButtons.OK);
                    }

                }
            }

        private void TXsearch_TextChanged(object sender, EventArgs e)
            {
            SearchTimer.Stop();
            SearchTimer.Start();
            }

        private void SearchTimer_Tick(object sender, EventArgs e)
            {
            SearchTimer.Stop();
            string catName = TXsearch.Text;
       
            List<Category> catlist = CategoryService.SearchCategory(catName);
            dataGridView1.DataSource = catlist;
     
            }
        }




    }
