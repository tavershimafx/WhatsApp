using System.Security;
using System.Windows.Input;
using WhatsApp.Core.Commands;
using WhatsApp.Core.DependencyInjection;

namespace WhatsApp.Core
{
    public class LoginPageViewModel : BaseViewModel
    {
        public string Email { get; set; }

        public SecureString Password { get; set; }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public LoginPageViewModel()
        {
            LoginCommand = new CommandBase(HandleLogin);
            RegisterCommand = new CommandBase(GoToRegister);
        }

        private void GoToRegister(object o)
        {
            ServiceContainer.ApplicationState.NavigateToPage(ApplicationPage.Register);
        }
        private void HandleLogin(object parameter)
        {
            ServiceContainer.ApplicationState.SessionToken = "jsonwebToken";
            ServiceContainer.ApplicationState.NavigateToPage(ApplicationPage.Chat);
        }
    }
}