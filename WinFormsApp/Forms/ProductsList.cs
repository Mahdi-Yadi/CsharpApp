using WinFormsApp.Forms.Products;
namespace WinFormsApp.Forms;
public partial class ProductsList : Form
{
    public ProductsList()
    {
        InitializeComponent();
    }

    private void btnadd_Click(object sender, EventArgs e)
    {
        AddProductFRM add = new AddProductFRM();
        add.ShowDialog();
    }

}