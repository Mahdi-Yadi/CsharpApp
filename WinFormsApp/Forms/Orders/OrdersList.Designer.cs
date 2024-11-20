namespace WinFormsApp.Forms.Orders
{
    partial class OrdersList
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
            dataGridOrders = new DataGridView();
            btn_info = new Button();
            btn_search = new Button();
            txtSearch = new Label();
            txtsearchOrderId = new TextBox();
            btn_pay = new Button();
            btn_delete = new Button();
            btn_editOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridOrders
            // 
            dataGridOrders.BackgroundColor = Color.MediumSeaGreen;
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.GridColor = SystemColors.InfoText;
            dataGridOrders.Location = new Point(12, 12);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.Size = new Size(660, 207);
            dataGridOrders.TabIndex = 1;
            // 
            // btn_info
            // 
            btn_info.BackColor = Color.LightSeaGreen;
            btn_info.Location = new Point(562, 288);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(110, 41);
            btn_info.TabIndex = 5;
            btn_info.Text = "جزییات فاکتور";
            btn_info.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.Highlight;
            btn_search.Location = new Point(330, 239);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(88, 26);
            btn_search.TabIndex = 8;
            btn_search.Text = "جستجو";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.Location = new Point(628, 242);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(41, 15);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "جستجو";
            // 
            // txtsearchOrderId
            // 
            txtsearchOrderId.Location = new Point(457, 239);
            txtsearchOrderId.Name = "txtsearchOrderId";
            txtsearchOrderId.Size = new Size(144, 23);
            txtsearchOrderId.TabIndex = 6;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.LimeGreen;
            btn_pay.Location = new Point(446, 288);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(110, 41);
            btn_pay.TabIndex = 9;
            btn_pay.Text = "پرداخت فاکتور";
            btn_pay.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Brown;
            btn_delete.Location = new Point(330, 288);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(110, 41);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "حذف فاکتور";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_editOrder
            // 
            btn_editOrder.BackColor = Color.Cyan;
            btn_editOrder.Location = new Point(208, 288);
            btn_editOrder.Name = "btn_editOrder";
            btn_editOrder.Size = new Size(110, 41);
            btn_editOrder.TabIndex = 11;
            btn_editOrder.Text = "ویرایش فاکتور";
            btn_editOrder.UseVisualStyleBackColor = false;
            // 
            // OrdersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(684, 351);
            Controls.Add(btn_editOrder);
            Controls.Add(btn_delete);
            Controls.Add(btn_pay);
            Controls.Add(btn_search);
            Controls.Add(txtSearch);
            Controls.Add(txtsearchOrderId);
            Controls.Add(btn_info);
            Controls.Add(dataGridOrders);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrdersList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersList";
            Load += OrdersList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridOrders;
        private Button btn_info;
        private Button btn_search;
        private Label txtSearch;
        private TextBox txtsearchOrderId;
        private Button btn_pay;
        private Button btn_delete;
        private Button btn_editOrder;
    }
}