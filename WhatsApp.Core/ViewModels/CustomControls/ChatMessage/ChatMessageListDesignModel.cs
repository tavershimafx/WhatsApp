namespace WhatsApp.Core
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel, IBaseDesignViewModel<ChatMessageListDesignModel>
    {
        public static ChatMessageListDesignModel Instance { get; set; } = new();
        public ChatMessageListDesignModel()
        {
            Items = SeedData.ChatMessages();
        }
    }
}
