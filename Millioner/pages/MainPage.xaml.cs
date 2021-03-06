using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WMPLib;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        WindowsMediaPlayer player2;

        bool isplay;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonStartGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GamePage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {


          


            player2 = new WindowsMediaPlayer();
            player2.URL = "million.mp3";
            player2.settings.setMode("loop", true);
            player2.settings.volume = 100;

            player2.controls.play();
            isplay = true;

            if (isplay == true)
            {
                player2.controls.stop();
                isplay = false;
            }
        }

        private void btnVolume_Click(object sender, RoutedEventArgs e)
        {
            if (isplay)
            {
                player2.controls.stop();
                isplay = false;
                btnVolume.Content = "Включить музыку";
            }
            else
            {
                player2.controls.play();
                isplay = true;
                btnVolume.Content = "Выключить музыку";
            }
        }
    }
}
