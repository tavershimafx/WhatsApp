
using System.Security;
using System.Windows.Input;
using WhatsApp.Core.Commands;
using WhatsApp.Core.DependencyInjection;

namespace WhatsApp.Core
{
    public class RegisterPageViewModel : BaseViewModel
    {
        public string Email { get; set; }

        public SecureString Password { get; set; }

        /// <summary>
        /// A command to switch to the login page
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// A command To register the user to the server
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        public RegisterPageViewModel()
        {
            RegisterCommand = new CommandBase(HandleRegister);
            LoginCommand = new CommandBase((object o) => ServiceContainer.ApplicationState.NavigateToPage(ApplicationPage.Login));
        }

        private void HandleRegister(object parameter)
        {
            
        }
    }
}