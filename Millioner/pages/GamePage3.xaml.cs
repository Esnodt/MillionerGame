using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GamePage3.xaml
    /// </summary>
    public partial class GamePage3 : Page
    {
        public GamePage3()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void otvet1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void otvet2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void otvet3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void otvet4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ верный, умница!", "Уведомление");
            NavigationService.Navigate(new GamePageSave());
        }
    }
}
