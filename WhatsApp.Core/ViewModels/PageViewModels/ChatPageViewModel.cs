using System.Collections.ObjectModel;

namespace WhatsApp.Core
{
    public class ChatPageViewModel : BaseViewModel
    {

        #region Public Properties
        public RecentChatListViewModel SelectedChat { get; set; }

        public ChatMessageListViewModel LoadedChat { get; set; }
        #endregion

        public ChatPageViewModel()
        {
            SelectedChat = SeedData.RecentChatList();
            LoadedChat = SeedData.ChatMessageList();
        }
    }
}