using Millioner.Properties;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GamePage5.xaml
    /// </summary>
    public partial class GamePage5 : Page
    {
        public GamePage5()
        {
            InitializeComponent();

            if (Settings.Default.Fifty == true)
            {
                ButtonFifty.Visibility = Visibility.Hidden;
            }
        }


        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void otvet1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Точно! Следующий вопрос!", "Уведомление");
            NavigationService.Navigate(new GamePage6());
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
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void buttonOR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonfriend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOR1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOR1_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonFifty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Buttoncall_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
