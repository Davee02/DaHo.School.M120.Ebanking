using System.Windows;
using DaHo.School.M120.Ebanking.Services;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for OverviewView.xaml
    /// </summary>
    public partial class OverviewView : Window
    {
        public OverviewView()
        {
            InitializeComponent();

            var tracker = TrackerService.JotTracker;
            tracker.Track(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new CurrencyView().ShowDialog();
            Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            new SendMoneyView().ShowDialog();
            Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            new ReceiveMoneyView().ShowDialog();
            Show();
        }
    }
}
