using System.Windows.Forms.Design;

namespace Sales.PL
{
    public partial class MainUi : Form
        {
        public MainUi()
            {
            InitializeComponent();
            }

        private void BT_CATEGORY_Click(object sender, EventArgs e)
            {
            categoryFrm cat_frm = new categoryFrm();
            //this.Hide();
            cat_frm.ShowDialog();
            //this.Show();

            }

        private void BT_PRODUCT_Click(object sender, EventArgs e)
            {
            productFrm prod_frm = new productFrm();
           
            prod_frm.ShowDialog();
            

            }
        }
    }
