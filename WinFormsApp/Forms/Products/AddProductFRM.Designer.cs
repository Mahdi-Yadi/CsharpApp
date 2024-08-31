namespace WinFormsApp.Forms.Products
{
    partial class AddProductFRM
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
            btnadd = new Button();
            txtSearch = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Location = new Point(233, 116);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(88, 26);
            btnadd.TabIndex = 6;
            btnadd.Text = "ثبت";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Location = new Point(481, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(64, 15);
            txtSearch.TabIndex = 5;
            txtSearch.Text = "نام محصول";
            // 
            // txtName
            // 
            txtName.Location = new Point(307, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(144, 23);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 26);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "قیمت محصول";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(33, 23);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(144, 23);
            txtPrice.TabIndex = 7;
            // 
            // AddProductFRM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 165);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(btnadd);
            Controls.Add(txtSearch);
            Controls.Add(txtName);
            Name = "AddProductFRM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductFRM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadd;
        private Label txtSearch;
        private TextBox txtName;
        private Label label1;
        private TextBox txtPrice;
    }
}