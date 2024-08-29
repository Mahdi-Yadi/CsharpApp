using WinFormsApp.Module;

namespace WinFormsApp.Forms;
public partial class MainForm : Form
{
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
}