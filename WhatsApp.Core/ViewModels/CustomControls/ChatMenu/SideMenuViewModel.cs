namespace WhatsApp.Core
{
    public class SideMenuViewModel : BaseViewModel
    {
        #region Public properties

        public RecentChatListViewModel RecentChats { get; set; }

        public string SearchString { get; set; }

        #endregion

        public SideMenuViewModel()
        {

        }
    }
}
