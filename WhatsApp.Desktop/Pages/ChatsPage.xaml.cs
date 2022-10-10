using System.Windows.Controls;
using WhatsApp.Core;

namespace WhatsApp.Desktop
{
    /// <summary>
    /// Interaction logic for ChatsPage.xaml
    /// </summary>
    public partial class ChatPage : BaseControl<ChatPageViewModel>
    {
        public ChatPage()
        {
            InitializeComponent();
            this.EntryAnimation = EntryAnimation.None;
            this.ExitAnimation = ExitAnimation.None;
        }
    }
}
