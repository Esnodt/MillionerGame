using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GamePage7.xaml
    /// </summary>
    public partial class GamePage7 : Page
    {
        public GamePage7()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void otvet1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Точно! Следующий вопрос!", "Уведомление");
            NavigationService.Navigate(new GameSaveEnd());
        }

        private void otvet2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new GamePage5());
        }

        private void otvet3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void otvet4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new GamePageSave());
        }

        private void buttonfriend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonOR_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
