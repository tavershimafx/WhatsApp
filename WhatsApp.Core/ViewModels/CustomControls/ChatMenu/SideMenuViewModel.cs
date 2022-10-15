using System.Windows.Input;
using WhatsApp.Core.Commands;

namespace WhatsApp.Core
{
    public class SideMenuViewModel : BaseViewModel
    {
        #region Public properties

        /// <summary>
        /// The selected chat from the left sidebar which in turn fetches its
        /// details into the right pane
        /// </summary>
        public RecentChatListViewModel SelectedChat { get; set; }

        /// <summary>
        /// A flag to determine if the chat setting popup should be visible.
        /// </summary>
        public bool ShowChatSettingPopup { get; set; }

        /// <summary>
        /// A flag to determine if the new chat side menu should be visible
        /// </summary>
        public bool ShowNewChatSideMenu { get; set; }

        /// <summary>
        /// The profile picture url of the account owner
        /// </summary>
        public string AccountProfilePictureUrl { get; set; } = "Resources/Images/me.jpeg";
        #endregion

        #region Public commands

        /// <summary>
        /// A command to handle the recording voice notes
        /// </summary>
        public ICommand TogglePopupCommand { get; set; }

        #endregion

        public SideMenuViewModel()
        {
            SelectedChat = SeedData.RecentChatList();
            TogglePopupCommand = new CommandBase(TogglePopup);
        }

        /// <summary>
        /// Handler for toggling different popups and side menus.
        /// </summary>
        /// <param name="obj"></param>
        private void TogglePopup(object name)
        {
            switch ((string)name)
            {
                case ChatSettingMenu.Setting:
                    this.ShowChatSettingPopup ^= true;
                    return;
                case ChatSettingMenu.NewChat:
                    this.ShowNewChatSideMenu ^= true;
                    return;
                default:
                    break;
            }
        }

        /// <summary>
        /// Popup identifiers
        /// </summary>
        static class ChatSettingMenu
        {
            /// <summary>
            /// Identifier for the chat setting popup
            /// </summary>
            public const string Setting = "Setting";

            /// <summary>
            /// Identifier for new chat sidebar
            /// </summary>
            public const string NewChat = "NewChat";
        }
    }
}
