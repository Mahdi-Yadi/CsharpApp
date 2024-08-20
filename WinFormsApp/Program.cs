using WinFormsApp.Forms;
namespace WinFormsApp;
internal static class Program
{
    [STAThread]
    static void Main()
    {

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}