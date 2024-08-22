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

    private void button2_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dataUsers.CurrentRow.Cells["Id"].Value.ToString());

        var user = _db.Users.FirstOrDefault(u => u.Id == id);

        if (user != null)
        {
            _db.Users.Remove(user);
            _db.SaveChanges();
            dataUsers.DataSource = _db.Users.ToList();
            MessageBox.Show("کاربر حذف شد");
        }

    }

    private void button3_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dataUsers.CurrentRow.Cells["Id"].Value.ToString());

        var user = _db.Users.FirstOrDefault(u => u.Id == id);

        if (user != null)
        {
            user.Name = txtName.Text;
            user.PhonNumber = TxtPhone.Text;
            _db.SaveChanges(); 
            dataUsers.DataSource = _db.Users.ToList();
            MessageBox.Show("کاربر ویرایش شد");
        }
    }

    private void dataUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
        int id = Convert.ToInt32(dataUsers.CurrentRow.Cells["Id"].Value.ToString());
        var user = _db.Users.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            txtName.Text = user.Name;
            TxtPhone.Text = user.PhonNumber;
        }
    }
}