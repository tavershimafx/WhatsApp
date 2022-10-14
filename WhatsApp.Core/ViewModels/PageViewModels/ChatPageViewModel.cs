using System.Collections.ObjectModel;
using System.Windows.Input;
using WhatsApp.Core.Commands;

namespace WhatsApp.Core
{
    public class ChatPageViewModel : BaseViewModel
    {

        #region Public Properties
        public RecentChatListViewModel SelectedChat { get; set; }

        public ChatMessageListViewModel LoadedChat { get; set; }

        /// <summary>
        /// A flag to determine if to show the popup menu for emoji
        /// </summary>
        public bool ShowEmojiPopup { get; set; }

        /// <summary>
        /// A flag if to show the popup menu for attachment
        /// </summary>
        public bool ShowAttachmentPopup { get; set; }
        #endregion

        #region Public commands

        /// <summary>
        /// A command to handle the emoji click button
        /// </summary>
        public ICommand EmojiAttachmentCommand { get; set; }

        /// <summary>
        /// A command to handle the resource attachment button
        /// </summary>
        public ICommand ResourceAttachmentCommand { get; set; }

        #endregion

        public ChatPageViewModel()
        {
            SelectedChat = SeedData.RecentChatList();
            LoadedChat = SeedData.ChatMessageList();

            EmojiAttachmentCommand = new CommandBase(HandleEmoji);
            ResourceAttachmentCommand = new CommandBase(HandleResourceAttachment);
        }

        private void HandleResourceAttachment(object obj)
        {
            this.ShowAttachmentPopup ^= true;
        }

        private void HandleEmoji(object obj)
        {
            this.ShowEmojiPopup ^= true;
        }
    }
}