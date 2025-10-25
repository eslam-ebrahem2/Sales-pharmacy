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

namespace Sales.PL {
    public partial class categoryFrm : Form {
        public categoryFrm() {
            InitializeComponent();
            }

        private void ButAdd_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(TXcategory.Text)) {
                MessageBox.Show("please add category name", "error", MessageBoxButtons.OK);
                return;
                }
            Category Cat = new Category() {
                Name = TXcategory.Text

                };

            bool isAdd = CategoryService.addCategory(Cat);
            if (isAdd) {
                MessageBox.Show("add sucsess", "sucsess", MessageBoxButtons.OK);
                fillDG();
                }
            else {
                MessageBox.Show("erorr adding ", "error", MessageBoxButtons.OK);
                }

            }
           //----------------------------------------------------------------
        private void categoryFrm_Load(object sender, EventArgs e) {

            fillDG();
            }

          //----------------------------------------------------------------
        private void fillDG() {
            List<Category> catlist = CategoryService.getallCategory();
            dataGridView1.DataSource = catlist;
            }



        }




    }
