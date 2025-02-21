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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyStarShop
{
    public partial class FrmProducts : Form
    {
        int dataPageControlCount = 0, showDataCount = 3, dataCount = 1;
        int totalPage, thisPage = 1;
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            showDataCount = (int)showDataCountNumUp.Value;
            AllShowProducts();
            int DtPg = DataAndPageMod();


            UpdatePagesInfo(1, DtPg);

        }

        private void UpdatePagesInfo(int thisPageInfo, int totalPageInfo)
        {
            totalPage = totalPageInfo;

            pageInfoLabel.Text = $"{thisPage}/{totalPageInfo}";
        }

        private void AllShowProducts()
        {
            string query = $@"Select p.productID,
	                            c.categoryName,
	                            pd.description,
	                            pd.unitPrice,
	                            pd.stock 
                            From Products p
	                            Inner Join ProductDetails pd
                            On pd.productID=p.productID
	                            Inner Join Categories c
                            On c.categoryID=p.categoryID
							    order by p.productID
							Offset {dataPageControlCount} Rows Fetch Next {showDataCount} Rows only ";
            using DbConnectionHelper dbConnectionHelper = new();

            productsDGW.DataSource = dbConnectionHelper.DbShowList<Product>(query);

            productsDGW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            productsDGW.Columns[0].HeaderText = "Ürün Numarası";
            productsDGW.Columns[1].HeaderText = "Kategory Adı";
            productsDGW.Columns[2].HeaderText = "Ürün Açıklaması";
            productsDGW.Columns[3].HeaderText = "Birim Fiyatı";
            productsDGW.Columns[4].HeaderText = "Stok Adeti";


        }

        private int DataProductCount()
        {

            string query = "Select COUNT(0) from Products";
            using DbConnectionHelper dbConnectionHelper = new();
            return dbConnectionHelper.DbDataCount(query);

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            int dataPageInfo = DataAndPageMod();


            if (thisPage < dataPageInfo)
            {
                dataPageControlCount += showDataCount;
                thisPage++;
                UpdatePagesInfo(thisPage, dataPageInfo);

                AllShowProducts();
            }


        }


        private int DataAndPageMod()
        {
            dataCount = DataProductCount();

            if (dataCount % showDataCount == 0)
            {

                if (dataPageControlCount <= (dataCount / showDataCount))
                {


                    return (dataCount / showDataCount);


                }


            }

            return (dataCount / showDataCount) + 1;

        }


        private void backButton_Click(object sender, EventArgs e)
        {
            int dtPg = DataAndPageMod();
            if (dataPageControlCount - showDataCount >= 0)
            {
                dataPageControlCount -= showDataCount;
                AllShowProducts();
                thisPage--;

            }
            UpdatePagesInfo(thisPage, dtPg);


        }

        private void showDataCountNumUp_Leave(object sender, EventArgs e)
        {
            showDataCount = (int)showDataCountNumUp.Value;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dataPageControlCount = 0;

            AllShowProducts();
            UpdatePagesInfo(thisPage, DataAndPageMod());
            // UpdatePagesInfo(dataPageControlCount, (dataCount / showDataCount) + 1);

        }


    }
}
