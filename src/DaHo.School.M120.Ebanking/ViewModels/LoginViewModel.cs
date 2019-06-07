using System.Security;
using System.Windows.Input;
using DaHo.Library.Utilities;
using DaHo.Library.Wpf;
using DaHo.School.M120.Ebanking.Models;
using DaHo.School.M120.Ebanking.Views;

namespace DaHo.School.M120.Ebanking.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginModel Login { get; set; } = new LoginModel();

        public SecureString SecurePassword { get; set; }

        public ICommand ForgotPasswordCommand { get; set; }

        public ICommand LogInCommand { get; set; }


        public LoginViewModel()
        {
            ForgotPasswordCommand = new RelayCommand(_ => ForgotPassword());
            LogInCommand = new RelayCommand(_ => LogIn());
        }

        private void ForgotPassword()
        {
            HideAction();
            new ResetPasswordView().ShowDialog();
            ShowAction();
        }

        private void LogIn()
        {
            Login.Password = SecurePassword?.ConvertToString();
            Login.Validate();
            if (Login.HasErrors)
            {
                DisplayDataErrors(Login.GetErrors(), new MessageboxDialogService());
                return;
            }

            HideAction();
            new OverviewView().ShowDialog();
            CloseAction();
        }
    }
}
