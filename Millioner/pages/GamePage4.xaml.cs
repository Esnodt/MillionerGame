using Millioner.Properties;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GamePage4.xaml
    /// </summary>
    public partial class GamePage4 : Page
    {
        public GamePage4()
        {
            InitializeComponent();
            if(Settings.Default.Fifty == false)
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
            MessageBox.Show("Ответ неверный. Вы проиграли", "Уведомление");
            NavigationService.Navigate(new MainPage());
        } 

        private void otvet2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действительно, а вы умны!", "Уведомление");
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
            NavigationService.Navigate(new MainPage());
        }

        private void ButtonFifty_Click(object sender, RoutedEventArgs e)
        {

            otvet4.Visibility = Visibility.Hidden;
            otvet1.Visibility = Visibility.Hidden;

            ButtonFifty.Visibility = Visibility.Hidden;
            Settings.Default.Fifty = true;
            Settings.Default.Save();

        }


        private void Buttoncall_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
