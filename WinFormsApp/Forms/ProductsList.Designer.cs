namespace WinFormsApp.Forms
{
    partial class ProductsList
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
            dataGridProducts = new DataGridView();
            txt = new TextBox();
            txtSearch = new Label();
            button1 = new Button();
            btnadd = new Button();
            btnedit = new Button();
            btndelete = new Button();
            btndetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridProducts
            // 
            dataGridProducts.BackgroundColor = Color.PaleTurquoise;
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Location = new Point(12, 12);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.Size = new Size(685, 216);
            dataGridProducts.TabIndex = 0;
            // 
            // txt
            // 
            txt.Location = new Point(453, 246);
            txt.Name = "txt";
            txt.Size = new Size(144, 23);
            txt.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Location = new Point(641, 249);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(41, 15);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "جستجو";
            // 
            // button1
            // 
            button1.Location = new Point(343, 246);
            button1.Name = "button1";
            button1.Size = new Size(88, 26);
            button1.TabIndex = 3;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Lime;
            btnadd.Location = new Point(587, 300);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(110, 41);
            btnadd.TabIndex = 4;
            btnadd.Text = "افزودن محصول ";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.DarkOrchid;
            btnedit.Location = new Point(471, 300);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(110, 41);
            btnedit.TabIndex = 5;
            btnedit.Text = "ویرایش محصول ";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Crimson;
            btndelete.Location = new Point(355, 300);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(110, 41);
            btndelete.TabIndex = 6;
            btndelete.Text = "حذف محصول ";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btndetail
            // 
            btndetail.BackColor = Color.Aqua;
            btndetail.Location = new Point(239, 300);
            btndetail.Name = "btndetail";
            btndetail.Size = new Size(110, 41);
            btndetail.TabIndex = 7;
            btndetail.Text = "جزییات محصول ";
            btndetail.UseVisualStyleBackColor = false;
            btndetail.Click += btndetail_Click;
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 360);
            Controls.Add(btndetail);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(button1);
            Controls.Add(txtSearch);
            Controls.Add(txt);
            Controls.Add(dataGridProducts);
            Name = "ProductsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "محصولات";
            Load += ProductsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProducts;
        private TextBox txt;
        private Label txtSearch;
        private Button button1;
        private Button btnadd;
        private Button btnedit;
        private Button btndelete;
        private Button btndetail;
    }
}