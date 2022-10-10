using WhatsApp.Core.ViewModels.Enums;

namespace WhatsApp.Core
{
    public class ChatMessageDesignModel : ChatMessageViewModel, IBaseDesignViewModel<ChatMessageDesignModel>
    {
        public static ChatMessageDesignModel Instance { get; set; } = new ();
        public ChatMessageDesignModel()
        {
            MessageType = MessageType.Text;
            Message = "Hello Kosi, How was today. Hope you had a great day in church today";
            SentByMe = true;
            MessageSentTime = DateTime.Now;
        }
    }
}
