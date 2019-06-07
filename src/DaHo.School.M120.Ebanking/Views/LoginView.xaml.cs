using System.Windows;
using System.Windows.Controls;
using DaHo.School.M120.Ebanking.Services;
using DaHo.School.M120.Ebanking.ViewModels;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();

            var tracker = TrackerService.JotTracker;
            tracker.Track(this);
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                ((LoginViewModel)DataContext).SecurePassword = passwordBox.SecurePassword;
            }
        }
    }
}
