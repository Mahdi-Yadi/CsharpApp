namespace WinFormsApp.Forms;
public partial class MainForm : Form
{

    public MainForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show(textBox1.Text);
    }

}