using System.Windows;

namespace GWOS.UI
{
    public partial class CreateItemOrder : Window
    {
        public CreateItemOrder()
        {
            InitializeComponent();
        }
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}