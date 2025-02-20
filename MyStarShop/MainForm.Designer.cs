namespace MyStarShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productsSM = new ToolStripMenuItem();
            allProductsSM = new ToolStripMenuItem();
            addProductSM = new ToolStripMenuItem();
            categoriesSM = new ToolStripMenuItem();
            allCategoriesSM = new ToolStripMenuItem();
            addCategorySM = new ToolStripMenuItem();
            customersSM = new ToolStripMenuItem();
            allCustomersSM = new ToolStripMenuItem();
            addCustomerSM = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsSM, categoriesSM, customersSM });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1072, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productsSM
            // 
            productsSM.DropDownItems.AddRange(new ToolStripItem[] { allProductsSM, addProductSM });
            productsSM.Name = "productsSM";
            productsSM.Size = new Size(58, 20);
            productsSM.Text = "Ürünler";
            // 
            // allProductsSM
            // 
            allProductsSM.Name = "allProductsSM";
            allProductsSM.Size = new Size(141, 22);
            allProductsSM.Text = "Tüm Ürünler";
            allProductsSM.Click += allProductsSM_Click;
            // 
            // addProductSM
            // 
            addProductSM.Name = "addProductSM";
            addProductSM.Size = new Size(141, 22);
            addProductSM.Text = "Ürün Ekle";
            // 
            // categoriesSM
            // 
            categoriesSM.DropDownItems.AddRange(new ToolStripItem[] { allCategoriesSM, addCategorySM });
            categoriesSM.Name = "categoriesSM";
            categoriesSM.Size = new Size(76, 20);
            categoriesSM.Text = "Kategoriler";
            // 
            // allCategoriesSM
            // 
            allCategoriesSM.Name = "allCategoriesSM";
            allCategoriesSM.Size = new Size(159, 22);
            allCategoriesSM.Text = "Tüm Kategoriler";
            // 
            // addCategorySM
            // 
            addCategorySM.Name = "addCategorySM";
            addCategorySM.Size = new Size(159, 22);
            addCategorySM.Text = "Kategory Ekle";
            // 
            // customersSM
            // 
            customersSM.DropDownItems.AddRange(new ToolStripItem[] { allCustomersSM, addCustomerSM });
            customersSM.Name = "customersSM";
            customersSM.Size = new Size(72, 20);
            customersSM.Text = "Müşteriler";
            // 
            // allCustomersSM
            // 
            allCustomersSM.Name = "allCustomersSM";
            allCustomersSM.Size = new Size(180, 22);
            allCustomersSM.Text = "Tüm Müşteriler";
            allCustomersSM.Click += allCustomersSM_Click;
            // 
            // addCustomerSM
            // 
            addCustomerSM.Name = "addCustomerSM";
            addCustomerSM.Size = new Size(180, 22);
            addCustomerSM.Text = "Müşteri Ekle";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 592);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsSM;
        private ToolStripMenuItem allProductsSM;
        private ToolStripMenuItem addProductSM;
        private ToolStripMenuItem categoriesSM;
        private ToolStripMenuItem allCategoriesSM;
        private ToolStripMenuItem customersSM;
        private ToolStripMenuItem allCustomersSM;
        private ToolStripMenuItem addCustomerSM;
        private ToolStripMenuItem addCategorySM;
    }
}
