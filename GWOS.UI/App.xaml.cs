using System.Windows;

namespace GWOS.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void UnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Unhandled Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}