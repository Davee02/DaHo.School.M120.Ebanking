using System.Text.RegularExpressions;
using System.Windows;
using DaHo.Library.Wpf;
using DaHo.School.M120.Ebanking.Services;
using DaHo.School.M120.Ebanking.ViewModels;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for CurrencyView.xaml
    /// </summary>
    public partial class CurrencyWindow : Window
    {
        public CurrencyWindow()
        {
            var viewModel = new CurrencyViewModel(new MessageboxDialogService());
            DataContext = viewModel;
            InitializeComponent();

            var tracker = TrackerService.JotTracker;
            tracker.Track(this);
        }
    }
}
