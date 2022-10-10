using System.Collections.ObjectModel;
using System.Threading;

namespace WhatsApp.Core
{
    public class RecentChatListDesignModel : RecentChatListViewModel, IBaseDesignViewModel<RecentChatListDesignModel>
    {
        public static RecentChatListDesignModel Instance = new ();

        public RecentChatListDesignModel()
        {
            Items = SeedData.RecentChats();
        }
    }
}
