using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GamePageSave.xaml
    /// </summary>
    public partial class GamePageSave : Page
    {
        public GamePageSave()
        {
            InitializeComponent();
        }


        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void gamestop_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите забрать деньги?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Ваш выигрыш - 1000р!", "Уведомление");
                NavigationService.Navigate(new MainPage());
            }
        }

        private void gamenext_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите продолжить игру?", "Уведомление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                NavigationService.Navigate(new GamePage4());
            }
        }
    }
}
