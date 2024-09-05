using DataLayer;
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

}