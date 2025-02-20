using MyStarShop.DbControllers;
using MyStarShop.DbControllers.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStarShop
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {

            AllShowProducts();
        }
        private void AllShowProducts()
        {
            string query = @"Select p.productID,
	                            c.categoryName,
	                            pd.description,
	                            pd.unitPrice,
	                            pd.stock 
                            From Products p
	                            Inner Join ProductDetails pd
                            On pd.productID=p.productID
	                            Inner Join Categories c
                            On c.categoryID=p.categoryID";
            DbConnectionHelper dbConnectionHelper = new();

            productsDGW.DataSource = dbConnectionHelper.DbShowList<Product>(query);
        }
    }
}
