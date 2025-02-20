using MyStarShop.Helpers;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace MyStarShop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void allProductsSM_Click(object sender, EventArgs e)
        {
            SelectedFormOpen<FrmProducts>();//Açılacak Formu bu şekilde çağırabiliriz
        }


        private void allCustomersSM_Click(object sender, EventArgs e)
        {
            SelectedFormOpen<FrmCustomers>();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {

        }


        private void SelectedFormOpen<openingForm>() where openingForm : Form, new()
        {
            OpeningPages<openingForm> frm = new();
            frm.OpenForm(this);

        }


    }
}
