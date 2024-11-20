using DataLayer;

namespace WinFormsApp.Forms.Orders;
public partial class OrdersList : Form
{

    private readonly DBsContext dbContext = new DBsContext();

    public OrdersList()
    {
        InitializeComponent();
    }

    private void OrdersList_Load(object sender, EventArgs e)
    {
        try
        {
            dataGridOrders.DataSource = dbContext.Orders.ToList();
        }
        catch (Exception)
        {
            MessageBox.Show("بانک اطلاعاتی در دسترس نیست!");
            throw;
        }
    }
}