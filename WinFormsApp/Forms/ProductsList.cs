using DataLayer;
using DataLayer.Entities.Orders;
using WinFormsApp.Forms.Products;
namespace WinFormsApp.Forms;

public partial class ProductsList : Form
{

    private readonly DBsContext _ctx = new DBsContext();

    public ProductsList()
    {
        InitializeComponent();
    }

    private void btnadd_Click(object sender, EventArgs e)
    {
        AddProductFRM add = new AddProductFRM();
        add.ShowDialog();
        _ctx.Products = add._ctx.Products;
        dataGridProducts.DataSource = _ctx.Products.ToList();
    }

    private void ProductsList_Load(object sender, EventArgs e)
    {
        dataGridProducts.DataSource = _ctx.Products.ToList();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (txt.Text != "")
        {
            var products = _ctx.Products.Where(p => p.Name.Contains(txt.Text)).ToList();
            dataGridProducts.DataSource = products;
        }
    }

    private void btnedit_Click(object sender, EventArgs e)
    {
        if (dataGridProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("لطفا محصولی را انتخاب نمایید.");
            return;
        }
        int id = Convert.ToInt32(dataGridProducts.CurrentRow.Cells["Id"].Value.ToString());

        var product = _ctx.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            MessageBox.Show("محصولی یافت نشد");
            return;
        }
        AddProductFRM edit = new AddProductFRM();
        edit.txtName.Text = product.Name;
        edit.txtPrice.Text = product.Price;
        edit.Text = "ویرایش محصول";
        edit.IsEdit = true;
        edit.ProductID = product.Id;
        edit.ShowDialog();
        _ctx.Products = edit._ctx.Products;
        dataGridProducts.DataSource = _ctx.Products.ToList();
    }

    private void btndelete_Click(object sender, EventArgs e)
    {
        if (dataGridProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("لطفا محصولی را انتخاب نمایید.");
            return;
        }
        int id = Convert.ToInt32(dataGridProducts.CurrentRow.Cells["Id"].Value.ToString());

        var product = _ctx.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            MessageBox.Show("محصولی یافت نشد");
            return;
        }

        try
        {
            _ctx.Remove(product);
            _ctx.SaveChanges();

            MessageBox.Show("محصول شما حذف شد.");
            dataGridProducts.DataSource = _ctx.Products.ToList();
        }
        catch (Exception)
        {
            MessageBox.Show("خطایی رخ داده!");

            throw;
        }
    }

    private void btndetail_Click(object sender, EventArgs e)
    {
        if (dataGridProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("لطفا محصولی را انتخاب نمایید.");
            return;
        }
        int id = Convert.ToInt32(dataGridProducts.CurrentRow.Cells["Id"].Value.ToString());

        var product = _ctx.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            MessageBox.Show("محصولی یافت نشد");
            return;
        }
        AddProductFRM edit = new AddProductFRM();
        edit.txtName.Text = product.Name;
        edit.txtPrice.Text = product.Price;
        edit.Text = "جزییات محصول";
        edit.IsEdit = true;
        edit.ProductID = product.Id;
        edit.btnadd.Enabled = false;
        edit.ShowDialog();
    }

    private void BtnAddorder_Click(object sender, EventArgs e)
    {
        if (dataGridProducts.SelectedRows.Count == 0)
        {
            MessageBox.Show("لطفا محصولی را انتخاب نمایید.");
            return;
        }
        int id = Convert.ToInt32(dataGridProducts.CurrentRow.Cells["Id"].Value.ToString());

        var product = _ctx.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            MessageBox.Show("محصولی یافت نشد");
            return;
        }

        var oldOrder = _ctx.Orders.FirstOrDefault(o => o.IsOpen);

        if (oldOrder != null)
        {
            oldOrder.Sum += Convert.ToInt32(product.Price);

            _ctx.SaveChanges();

            var OldorderDetail = _ctx.OrderDetails.FirstOrDefault(od => od.OrderId == oldOrder.Id
            && od.ProductId == product.Id);

            if (OldorderDetail != null)
            {
                OldorderDetail.Count += 1;
            }
            else
            {
                OrderDetail orderDetail = new OrderDetail();

                orderDetail.OrderId = oldOrder.Id;
                orderDetail.ProductId = product.Id;
                orderDetail.Name = product.Name;
                orderDetail.Count = 1;
                orderDetail.Price = Convert.ToInt32(product.Price);

                _ctx.OrderDetails.Add(orderDetail);
                _ctx.SaveChanges();
            }
            MessageBox.Show("فاکتور بروز شد.");
        }
        else
        {
            Order order = new Order();

            order.IsOpen = true;
            order.FullName = "";
            order.Sum = Convert.ToInt32(product.Price);
            order.CreatedDate = DateTime.Now;

            _ctx.Orders.Add(order);
            _ctx.SaveChanges();

            OrderDetail orderDetail = new OrderDetail();

            orderDetail.OrderId = order.Id;
            orderDetail.ProductId = product.Id;
            orderDetail.Name = product.Name;
            orderDetail.Count = 1;
            orderDetail.Price = Convert.ToInt32(product.Price);

            _ctx.OrderDetails.Add(orderDetail);
            _ctx.SaveChanges();

            MessageBox.Show("فاکتور ثبت شد.");

        }

    }
}