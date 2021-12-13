using System.Windows;
using System.Windows.Input;

namespace GWOS.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewOrder(object sender, RoutedEventArgs e)
        {
            CreateOrder NewWindow = new CreateOrder();
            NewWindow.Show();
        }

        private void OpenOrder999999(object sender, RoutedEventArgs e)
        {
            Order999999 NewWindow = new Order999999();
            NewWindow.Show();
        }
    }
}