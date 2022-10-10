using System.Collections.ObjectModel;
using WhatsApp.Core.ViewModels.Enums;

namespace WhatsApp.Core
{
    /// <summary>
    /// A view model for the list of chat messages to display
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        /// <summary>
        /// A collection of chat messages
        /// </summary>
        public ObservableCollection<ChatMessageViewModel> Items { get; set; }

        /// <summary>
        /// The user's display name
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The user's unique identity
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The local path to the users' profile picture
        /// </summary>
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// Determines if the user is online
        /// </summary>
        public bool IsOnline { get; set; }
    }
}
