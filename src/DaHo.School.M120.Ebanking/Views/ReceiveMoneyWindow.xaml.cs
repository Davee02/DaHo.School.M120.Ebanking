using System.Windows;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for CurrencyView.xaml
    /// </summary>
    public partial class ReceiveMoneyWindow : Window
    {
        public ReceiveMoneyWindow()
        {
            InitializeComponent();

            var tracker = Services.JotTracker;
            tracker.Track(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
