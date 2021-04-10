using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Millioner.pages
{
    /// <summary>
    /// Логика взаимодействия для GameSaveEnd.xaml
    /// </summary>
    public partial class GameSaveEnd : Page
    {
        public GameSaveEnd()
        {
            InitializeComponent();
        }

        private void otvet2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы отдали деньги на благотворительность. Молодец", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }

        private void otvet1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы забрали деньги себе и прожили на них полмесяца", "Уведомление");
            NavigationService.Navigate(new MainPage());
        }
    }
}
