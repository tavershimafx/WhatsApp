using System.Collections.ObjectModel;
using System.Windows.Input;
using WhatsApp.Core.Commands;
using WhatsApp.Core.EventHandlers;

namespace WhatsApp.Core
{
    public class ChatPageViewModel : BaseViewModel
    {

        #region Public Properties

        public SideMenuViewModel SideMenu { get; set; }
        /// <summary>
        /// The messages from the currently selected chat which is loaded in the
        /// right pane for previous conversations to and from a selected user
        /// </summary>
        public ChatMessageListViewModel LoadedChat { get; set; }

        /// <summary>
        /// The left profile menu which slides in from left to edit the user's
        /// profile details.
        /// </summary>
        public UserProfileMenuViewModel ProfileMenu { get; set; }

        /// <summary>
        /// A flag to determine if to show the popup menu for emoji
        /// </summary>
        public bool ShowEmojiPopup { get; set; }

        /// <summary>
        /// A flag if to show the popup menu for attachment
        /// </summary>
        public bool ShowAttachmentPopup { get; set; }

        /// <summary>
        /// A flag if to set if a user wants to record a voice note wihich
        /// shows the voice note popup
        /// </summary>
        public bool ShowVoiceNotePopup { get; set; }

        /// <summary>
        /// A flag if to show the chat setting popup menu
        /// </summary>
        public bool ShowChatOptionsPopup { get; set; }

        /// <summary>
        /// A flag to show the overlay to hide modals on clickaway
        /// </summary>
        public bool OverlayVisible { get; set; }

        /// <summary>
        /// A flag to toggle the side menu in or out
        /// </summary>
        public bool ShowSearchSideMenu { get; set; }

        /// <summary>
        /// A flag to toggle the profile side menu in or out
        /// </summary>
        public bool ShowUserProfileSideMenu { get; set; }

        #endregion

        #region Public commands

        /// <summary>
        /// A command to handle the recording voice notes
        /// </summary>
        public ICommand TogglePopupCommand { get; set; }

        /// <summary>
        /// A command to close all popups when the bounded rectangle sends its
        /// event trigger
        /// </summary>
        public ICommand ClosePopupsCommand { get; set; }
        
        #endregion

        public ChatPageViewModel()
        {
            TogglePopupCommand = new CommandBase(TogglePopup);
            ClosePopupsCommand = new CommandBase(ClosePopups);

            LoadedChat = SeedData.ChatMessageList();
            SideMenu = new SideMenuViewModel();
            ProfileMenu = new UserProfileMenuViewModel() 
            { 
                Username = "Tavershima",
                AboutInfo = "Make sure your name is written in the book that is always read before the assembly.",
                ProfilePictureUrl = "Resources/Images/me.jpeg"
            };

            // Subscribe to the side menu's profile sidebar state changes
            this.SideMenu.UserProfileMenuStateChanged += SideMenu_PropertyChanged;
            this.ProfileMenu.UserProfileMenuStateChanged += SideMenu_PropertyChanged2;
        }

        private void SideMenu_PropertyChanged(object? sender, EventArgs e)
        {
            ShowUserProfileSideMenu ^= true;
        }

        private void SideMenu_PropertyChanged2(object? sender, EventArgs e)
        {
            ShowUserProfileSideMenu ^= true;
        }

        /// <summary>
        /// Close all the popups. This list is to be updated whenever a new popup is created.
        /// </summary>
        /// <param name="obj"></param>
        private void ClosePopups(object obj)
        {
            // Remove the overlay then close the popup
            this.OverlayVisible ^= true;

            this.ShowAttachmentPopup = false;
            this.ShowEmojiPopup = false;
            this.ShowVoiceNotePopup = false;
            this.ShowChatOptionsPopup = false;
            this.ShowSearchSideMenu = false;
        }

        /// <summary>
        /// Handler for toggling different popups. This list is to be updated whenever a new popup is created.
        /// </summary>
        /// <param name="obj"></param>
        private void TogglePopup(object name)
        {
            switch ((string)name)
            {
                case ChatPageMenu.Resource:
                    this.ShowAttachmentPopup ^= true;
                    break;
                case ChatPageMenu.Emoji:
                    this.ShowEmojiPopup ^= true;
                    break;
                case ChatPageMenu.VoiceNote:
                    this.ShowVoiceNotePopup ^= true;
                    break;
                case ChatPageMenu.ChatOptions:
                    this.ShowChatOptionsPopup ^= true;
                    break;
                case ChatPageMenu.SearchMenu:
                    this.ShowSearchSideMenu ^= true;
                    break;
                case ChatPageMenu.UserProfile:
                    this.ShowUserProfileSideMenu ^= true;
                    break;
                default:
                    break;
            }

            // toggle the overlay also
            this.OverlayVisible ^= true;
        }

        /// <summary>
        /// Chat menu identifiers
        /// </summary>
        static class ChatPageMenu
        {
            /// <summary>
            /// Identifier for resource attachment
            /// </summary>
            public const string Resource = "Resource";

            /// <summary>
            /// Identifier for emoji insertion
            /// </summary>
            public const string Emoji = "Emoji";

            /// <summary>
            /// Identifier for voice note recording
            /// </summary>
            public const string VoiceNote = "VoiceNote";

            /// <summary>
            /// Identifier to display the chat setting
            /// </summary>
            public const string ChatOptions = "ChatOptions";

            /// <summary>
            /// Identifier to display the search side menu
            /// </summary>
            public const string SearchMenu = "SearchMenu";

            /// <summary>
            /// Identifier for the user profile side menu.
            /// </summary>
            public const string UserProfile = "UserProfile";
        }
    }
}