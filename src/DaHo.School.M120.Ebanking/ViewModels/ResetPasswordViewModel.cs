using System.Windows.Input;
using DaHo.Library.Wpf;

namespace DaHo.School.M120.Ebanking.ViewModels
{
    public class ResetPasswordViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;


        public string Username { get; set; }

        public ICommand ResetPasswordCommand { get; set; }


        public ResetPasswordViewModel()
        {
            _dialogService = new MessageboxDialogService();
            ResetPasswordCommand = new RelayCommand(_ => ResetPassword(), 
                _ => !string.IsNullOrWhiteSpace(Username));
        }

        private void ResetPassword()
        {
            _dialogService.ShowInfoDialog("Sie werden in kürze eine E-Mail mit einem Wieserherstellungslink erhalten.",
                "Information");
            CloseAction();
        }
    }
}
