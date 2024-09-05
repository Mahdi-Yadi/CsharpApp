using DataLayer;
using DataLayer.Entities.Products;
namespace WinFormsApp.Forms.Products;
public partial class AddProductFRM : Form
{
    public bool IsEdit = false;
    public int ProductID;
    public readonly DBsContext _ctx = new DBsContext();

    public AddProductFRM()
    {
        InitializeComponent();
    }

    private void btnadd_Click(object sender, EventArgs e)
    {
        if (txtName.Text != "" && txtPrice.Text != "")
        {
            if (IsEdit)
            {
                var product = _ctx.Products.FirstOrDefault(p => p.Id == ProductID);

                product.Name = txtName.Text;
                product.Price = txtPrice.Text;
                product.UserId = Module.dataModule.UserId;
                _ctx.Products.Update(product);
                _ctx.SaveChanges();
                MessageBox.Show("ویرایش محصول با موفقیت ثبت شد");
                this.Close();
            }
            else
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
        }
        else
        {
            MessageBox.Show("لطفا نام و قیمت را وارد نمایید");
        }

    }
}