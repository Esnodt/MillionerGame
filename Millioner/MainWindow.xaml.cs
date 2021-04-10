using Millioner.pages;
using System.Windows;

namespace Millioner
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void buttonfriend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOR_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
