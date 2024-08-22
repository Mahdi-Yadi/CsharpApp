using DataLayer;
using DataLayer.Entities.Account;

namespace WinFormsApp.Forms;
public partial class MainForm : Form
{

    readonly DBsContext _db = new DBsContext();


    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

        User user = new User();

        user.Name = txtName.Text;
        user.PhonNumber = TxtPhone.Text;
        user.CreateDate = DateTime.Now;

        try
        {
            _db.Add(user);
            _db.SaveChanges();
            MessageBox.Show("کاربر ثبت شد");
            txtName.Text = "";
            TxtPhone.Text = "";
            dataUsers.DataSource = _db.Users.ToList();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }


    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        dataUsers.DataSource = _db.Users.ToList();
    }

}