using System.Windows.Input;
using WhatsApp.Core.Commands;

namespace WhatsApp.Core
{
    public class UserProfileMenuViewModel : BaseViewModel
    {
        #region Public events

        /// <summary>
        /// A public event to notify the chat page to toggle the profile sidebar
        /// </summary>
        public event EventHandler UserProfileMenuStateChanged;

        #endregion

        /// <summary>
        /// The user's display name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The user's about info
        /// </summary>
        public string AboutInfo { get; set; }

        /// <summary>
        /// The absolute path to local to the user's profile picture
        /// </summary>
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// The handler for the side menu toggle.
        /// </summary>
        public ICommand SideMenuToggleCommand { get; set; }

        public UserProfileMenuViewModel()
        {
            SideMenuToggleCommand = new CommandBase(ToggleCommand);
        }

        private void ToggleCommand(object obj)
        {
            this.UserProfileMenuStateChanged.Invoke(this, new EventArgs());
        }
    }
}
