﻿using DataLayer;
namespace WinFormsApp.Forms;
public partial class Login : Form
{

    public bool IsTrue = false;

    private readonly DBsContext _db = new DBsContext();

    public Login()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (txtname.Text != "")
        {
            var user = _db.Users.FirstOrDefault(u => u.Name == txtname.Text);
            if (user != null)
            {
                IsTrue = true;
                Module.dataModule.UserId = user.Id;
                this.Close();
            }
            else
            {
                MessageBox.Show("همچین کاربری یافت نشد!");
            }
        }
        else
        {
            MessageBox.Show("نام کاربری را وارد کنید");
        }
    }

    private void Login_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (IsTrue == false)
        {
            Application.Exit();
        }
    }

}