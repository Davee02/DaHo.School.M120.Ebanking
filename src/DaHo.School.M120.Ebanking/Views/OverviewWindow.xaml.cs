using System.Windows;
using DaHo.School.M120.Ebanking.Services;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for OverviewWindow.xaml
    /// </summary>
    public partial class OverviewWindow : Window
    {
        public OverviewWindow()
        {
            InitializeComponent();

            var tracker = TrackerService.JotTracker;
            tracker.Track(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new CurrencyWindow().ShowDialog();
            Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            new SendMoneyWindow().ShowDialog();
            Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            new ReceiveMoneyWindow().ShowDialog();
            Show();
        }
    }
}
