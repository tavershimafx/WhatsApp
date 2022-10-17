using System.Reflection;

namespace WhatsApp.Core
{
    /// <summary>
    /// A design model for recent chats.
    /// </summary>
    public class RecentChatDesignModel : RecentChatViewModel, IBaseDesignViewModel<RecentChatDesignModel>
    {
        public static RecentChatDesignModel Instance { get; set; }= new RecentChatDesignModel();

        public RecentChatDesignModel()
        {
            Username = "Kosi";
            ProfilePictureUrl = "Resources/Images/kosi.jpg";
            LastMessage = "Hey, how was today? Don't forget to include every bit of the gist tonight.";
            LastSeenTime = DateTimeOffset.Now;
            LastMessageTime = DateTimeOffset.Now;
            MessageReadTime = DateTimeOffset.Now;
            IsRead = false;
        }
    }
}
