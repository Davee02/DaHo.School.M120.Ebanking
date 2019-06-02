using System.Windows;
using System.Windows.Controls;
using DaHo.School.M120.Ebanking.ViewModels;

namespace DaHo.School.M120.Ebanking.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LoginViewModel _viewModel = new LoginViewModel();

        public LoginWindow()
        {
            DataContext = _viewModel;
            _viewModel.HideAction = Hide;
            _viewModel.CloseAction = Close;
            InitializeComponent();
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                _viewModel.SecurePassword = passwordBox.SecurePassword;
            }
        }
    }
}
