using System.Configuration;
using System.Data;
using System.Windows;

namespace Attendence_System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void StartupPage(object sender, StartupEventArgs e)
        {
            // Create an instance of MainWindow
            LoginWindow mainWindow = new LoginWindow();
            mainWindow.Title = "First Page";
            mainWindow.Show(); // Show MainWindow
        }
    }
}
