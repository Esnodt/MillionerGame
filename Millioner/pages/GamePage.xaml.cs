using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WMPLib;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {

        WindowsMediaPlayer player3;
        bool isplay;

        public GamePage()
        {
            InitializeComponent();
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            player3 = new WindowsMediaPlayer();
            player3.URL = "win.mp3";
            player3.settings.setMode("loop", true);
            player3.settings.volume = 100;

            player3.controls.stop();

            isplay = false;

        }

        private void otvet1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void otvet2_Click(object sender, RoutedEventArgs e)
        {



            MessageBox.Show("Правильный ответ!", "Уведомление");

            NavigationService.Navigate(new GamePage1());
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

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }




    }
}
