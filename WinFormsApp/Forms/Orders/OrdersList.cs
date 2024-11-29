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

    private void btn_pay_Click(object sender, EventArgs e)
    {
        if (dataGridOrders.SelectedRows.Count == 0)
        {
            MessageBox.Show("لطفا فکتوری را انتخاب نمایید.");
            return;
        }

        int id = Convert.ToInt32(dataGridOrders.CurrentRow.Cells["Id"].Value.ToString());

        var order = dbContext.Orders.FirstOrDefault(o => o.Id == id);

        if (order == null)
        {
            MessageBox.Show("فاکتوری یافت نشد!");
            return;
        }

        var res = MessageBox.Show("آیا مایل به پرداخت فاکتور هستید؟", $"فاکتور شماره {order.Id}", MessageBoxButtons.YesNo);

        if (res == DialogResult.Yes)
        {
            order.IsOpen = false;
            order.IsPay = true;

            dbContext.Orders.Update(order);
            dbContext.SaveChanges();
            MessageBox.Show("فاکتور با موفقیت پرداخت شد!");

            dataGridOrders.DataSource = dbContext.Orders.ToList();
        }
        else
        {

        }
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {
        if (dataGridOrders.SelectedRows.Count == 0)
        {
            MessageBox.Show("لطفا فکتوری را انتخاب نمایید.");
            return;
        }

        int id = Convert.ToInt32(dataGridOrders.CurrentRow.Cells["Id"].Value.ToString());

        var order = dbContext.Orders.FirstOrDefault(o => o.Id == id);

        var res = MessageBox.Show("آیا مایل به حذف فاکتور هستید؟", $"فاکتور شماره {order.Id}", MessageBoxButtons.YesNo);

        if (res == DialogResult.Yes)
        {
            var orderDetails = dbContext.OrderDetails.Where(o => o.OrderId == order.Id).ToList();

            if (orderDetails.Count > 0)
            {
                foreach (var item in orderDetails)
                {
                    dbContext.Remove(item);
                }
                dbContext.SaveChanges();
            }

            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
            MessageBox.Show("فاکتور با موفقیت حذف شد!");

            dataGridOrders.DataSource = dbContext.Orders.ToList();
        }
        else
        {

        }
    }
}