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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sales.PL
    {
    public partial class productFrm : Form
        {
        public productFrm()
            {
            InitializeComponent();
            }
        private void FillDGV()
            {
            List<Products> Prodctlist = ProductService.getallProducts();
            DGVproduct.DataSource = Prodctlist;
            texName.Text = "";
            texByPrice.Text = "";
            texSalePrice.Text = "";
            texQty.Text = "";

            }

        private void FillcombCategory()
            {
            List<Category> catlist = CategoryService.getallCategory();
            comboCategory.DataSource = null; // تنظيف القديم
            comboCategory.Items.Clear();
            comboCategory.ValueMember = "Id";
            comboCategory.DisplayMember = "Name";
            comboCategory.DataSource = catlist;
            comboCategory.SelectedIndex = 0;



            }

        private void butAdd_Click(object sender, EventArgs e)
            {

            if (string.IsNullOrEmpty(texName.Text))
                {
                MessageBox.Show("please add category name", "error", MessageBoxButtons.OK);
                return;
                }


            Products product = new Products()
                {

                Name = texName.Text,
                Price = double.Parse(texByPrice.Text),
                SalePrice = double.Parse(texSalePrice.Text),
                Qty = double.Parse(texQty.Text),

                CatId = int.Parse(comboCategory.SelectedValue?.ToString() ?? "")

                };

            bool isAdd = ProductService.AddProduct(product);
            if (isAdd)
                {
                MessageBox.Show("add sucsess", "sucsess", MessageBoxButtons.OK);
                FillDGV();
                }
            else
                {
                MessageBox.Show("erorr adding ", "error", MessageBoxButtons.OK);
                }
            }

        private void productFrm_Load(object sender, EventArgs e)
            {
            FillDGV();
            FillcombCategory();
            }

        private void butUpdate_Click(object sender, EventArgs e)
            {


            int id = int.Parse(DGVproduct.CurrentRow.Cells[0].Value.ToString() ?? "");

            try
                {


                bool sucsess = ProductService.EditProductById(id, texName.Text, double.Parse(texByPrice.Text), double.Parse(texSalePrice.Text), int.Parse(texQty.Text));
                if (sucsess)
                    {
                    MessageBox.Show("edit ok", "", MessageBoxButtons.OK);
                    }
                FillDGV();
                }
            catch
                {
                MessageBox.Show("error edit", "", MessageBoxButtons.OK);
                }



            }

        private void DGVproduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {

            texName.Text = DGVproduct.CurrentRow.Cells[1].Value.ToString() ?? "";
            texByPrice.Text = DGVproduct.CurrentRow.Cells[2].Value.ToString() ?? "";
            texSalePrice.Text = DGVproduct.CurrentRow.Cells[3].Value.ToString() ?? "";
            texQty.Text = DGVproduct.CurrentRow.Cells[4].Value.ToString() ?? "";
            comboCategory.SelectedValue = int.Parse(DGVproduct.CurrentRow.Cells[5].Value.ToString() ?? "");

            }

        private void butDelete_Click(object sender, EventArgs e)
            {
            int id = int.Parse(DGVproduct.CurrentRow.Cells[0].Value.ToString() ?? "");
            try
                {
                bool deleted = ProductService.DeleteProductById(id);
                if (deleted)
                    {
                    MessageBox.Show("delete ok", "", MessageBoxButtons.OK);
                    FillDGV();
                    }
                }
            catch
                {
                MessageBox.Show("Faild delete", "", MessageBoxButtons.OK);
                }
            }

        private void texByPrice_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                e.Handled = true;
                }

            }

        private void texSalePrice_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                e.Handled = true;
                }
            }



        private void texQty_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                e.Handled = true;
                }
            }

        private void texSearch_TextChanged(object sender, EventArgs e)
            {
            if (texSearch.Text != "")
                {
                if (radioByName.Checked)
                    {
                    try
                        {
                        List<Products> Prodctlist = ProductService.SearchPRODUCT(texSearch.Text);

                        DGVproduct.DataSource = Prodctlist;
                       
                        }
                    catch
                        {
                        MessageBox.Show("not found");
                        }

                    }
                else
                    {
                    try
                        {

                        List<Products> Prodctlist = ProductService.SearchPRODUCTbyid(int.Parse(texSearch.Text));
                        DGVproduct.DataSource = Prodctlist;
                        }
                    catch
                        {
                        MessageBox.Show("not found");
                        }
                   ;
                    }
                }
            else
                {
                FillDGV();
                }
            }

        private void texSearch_KeyPress(object sender, KeyPressEventArgs e)
            {
            if (radioById.Checked)
                {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    {
                    e.Handled = true;
                    }

                }

            }
        }
    }
