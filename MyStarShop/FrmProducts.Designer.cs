namespace MyStarShop
{
    partial class FrmProducts
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
            if (disposing && (components != null))
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
            productsDGW = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            nextButton = new Button();
            backButton = new Button();
            showDataCountNumUp = new NumericUpDown();
            label1 = new Label();
            updateButton = new Button();
            panel1 = new Panel();
            pageInfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productsDGW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showDataCountNumUp).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productsDGW
            // 
            productsDGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGW.Location = new Point(12, 145);
            productsDGW.Name = "productsDGW";
            productsDGW.ReadOnly = true;
            productsDGW.Size = new Size(776, 357);
            productsDGW.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 14);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "İsim ile Arama";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(155, 12);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "ARA";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // nextButton
            // 
            nextButton.BackColor = SystemColors.AppWorkspace;
            nextButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            nextButton.ForeColor = SystemColors.ButtonFace;
            nextButton.Location = new Point(710, 508);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(80, 41);
            nextButton.TabIndex = 3;
            nextButton.Text = "=>";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.AppWorkspace;
            backButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            backButton.ForeColor = SystemColors.ButtonFace;
            backButton.Location = new Point(608, 508);
            backButton.Name = "backButton";
            backButton.Size = new Size(80, 41);
            backButton.TabIndex = 4;
            backButton.Text = "<=";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // showDataCountNumUp
            // 
            showDataCountNumUp.Font = new Font("Segoe UI", 11F);
            showDataCountNumUp.Location = new Point(15, 28);
            showDataCountNumUp.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            showDataCountNumUp.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            showDataCountNumUp.Name = "showDataCountNumUp";
            showDataCountNumUp.Size = new Size(222, 27);
            showDataCountNumUp.TabIndex = 5;
            showDataCountNumUp.TextAlign = HorizontalAlignment.Center;
            showDataCountNumUp.Value = new decimal(new int[] { 2, 0, 0, 0 });
           
            showDataCountNumUp.Leave += showDataCountNumUp_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 6;
            label1.Text = "Gösterilecek Kayıt Adeti (Maximum 15)";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(58, 61);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(127, 41);
            updateButton.TabIndex = 7;
            updateButton.Text = "Güncelle";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(showDataCountNumUp);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(540, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 119);
            panel1.TabIndex = 8;
            // 
            // pageInfoLabel
            // 
            pageInfoLabel.AutoSize = true;
            pageInfoLabel.Location = new Point(393, 511);
            pageInfoLabel.Name = "pageInfoLabel";
            pageInfoLabel.Size = new Size(38, 15);
            pageInfoLabel.TabIndex = 9;
            pageInfoLabel.Text = "label2";
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(pageInfoLabel);
            Controls.Add(panel1);
            Controls.Add(backButton);
            Controls.Add(nextButton);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(productsDGW);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProducts";
            ShowInTaskbar = false;
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)productsDGW).EndInit();
            ((System.ComponentModel.ISupportInitialize)showDataCountNumUp).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsDGW;
        private TextBox textBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button nextButton;
        private Button backButton;
        private NumericUpDown showDataCountNumUp;
        private Label label1;
        private Button updateButton;
        private Panel panel1;
        private Label pageInfoLabel;
    }
}