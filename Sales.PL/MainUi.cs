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
               categoryFrm frm = new categoryFrm();
            this.Hide();
            frm.ShowDialog();
            this.Show();
           
            }
        }
    }
