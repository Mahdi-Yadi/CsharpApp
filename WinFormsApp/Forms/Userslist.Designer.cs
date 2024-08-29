namespace WinFormsApp.Forms
{
    partial class Userslist
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
            button1 = new Button();
            txtName = new TextBox();
            TxtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataUsers = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataUsers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Location = new Point(104, 139);
            button1.Name = "button1";
            button1.Size = new Size(77, 41);
            button1.TabIndex = 0;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(39, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 23);
            txtName.TabIndex = 1;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(39, 89);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(155, 23);
            TxtPhone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 50);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 89);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "تلفن";
            // 
            // dataUsers
            // 
            dataUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsers.Location = new Point(301, 21);
            dataUsers.Name = "dataUsers";
            dataUsers.Size = new Size(337, 340);
            dataUsers.TabIndex = 5;
            dataUsers.CellEnter += dataUsers_CellEnter;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Location = new Point(187, 139);
            button2.Name = "button2";
            button2.Size = new Size(81, 41);
            button2.TabIndex = 6;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Location = new Point(12, 139);
            button3.Name = "button3";
            button3.Size = new Size(77, 41);
            button3.TabIndex = 7;
            button3.Text = "ویرایش";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(650, 384);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataUsers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPhone);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private TextBox TxtPhone;
        private Label label1;
        private Label label2;
        private DataGridView dataUsers;
        private Button button2;
        private Button button3;
    }
}