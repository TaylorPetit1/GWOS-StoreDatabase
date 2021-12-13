using System.Windows;


namespace GWOS.UI
{
    public partial class CreateOrder : Window
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void CreateNewItemOrder(object sender, RoutedEventArgs e)
        {
            CreateItemOrder NewWindow = new CreateItemOrder();
            NewWindow.Show();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}