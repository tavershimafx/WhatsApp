using System.Collections.ObjectModel;

namespace WhatsApp.Core
{
    public class RecentChatListViewModel : BaseViewModel
    {
        public ObservableCollection<RecentChatViewModel> Items { get; set; }
    }
}
