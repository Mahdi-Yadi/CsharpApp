using DataLayer;
using WinFormsApp.Module;

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
            try
            {
                var user = _db.Users.FirstOrDefault(u => u.Name == txtname.Text);
                if (user != null)
                {
                    IsTrue = true;
                    dataModule.UserId = user.Id;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("همچین کاربری یافت نشد!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("بانک اطلاعاتی در دسترس نیست!");
                return;
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

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }
}