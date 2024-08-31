using DataLayer;
using DataLayer.Entities.Products;
namespace WinFormsApp.Forms.Products;
public partial class AddProductFRM : Form
{

    public readonly DBsContext _ctx = new DBsContext();

    public AddProductFRM()
    {
        InitializeComponent();
    }

    private void btnadd_Click(object sender, EventArgs e)
    {
        if (txtName.Text != "" && txtPrice.Text != "")
        {

            Product product = new Product();

            product.Name = txtName.Text;
            product.Price = txtPrice.Text;
            product.UserId = Module.dataModule.UserId;
            product.CreatedDate = DateTime.Now;

            _ctx.Products.Add(product);
            _ctx.SaveChanges();
            MessageBox.Show("محصول جدید با موفقیت ثبت شد");
            this.Close();
        }
        else
        {
            MessageBox.Show("لطفا نام و قیمت را وارد نمایید");
        }
    }
}