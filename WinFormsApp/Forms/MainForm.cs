using WinFormsApp.Forms.Orders;

namespace WinFormsApp.Forms;
public partial class MainForm : Form
{

    private bool isLoged = false;

    public MainForm()
    {
        InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        Userslist userslist = new Userslist();
        userslist.ShowDialog();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        ProductsList productslist = new ProductsList();
        productslist.ShowDialog();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        isLoged = false;

        if (isLoged == false)
        {
            Login login = new Login();

            login.ShowDialog();

            if (login.IsTrue == true)
            {
                isLoged = true;
                login.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری را وارد کنید");
            }
        }

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
        OrdersList orderslist = new OrdersList();

        orderslist.ShowDialog();
    }
}