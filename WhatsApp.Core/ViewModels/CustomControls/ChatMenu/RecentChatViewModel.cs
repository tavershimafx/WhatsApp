namespace WhatsApp.Core
{
    /// <summary>
    /// A view model to display the recent chat in a conversation.
    /// </summary>
    public class RecentChatViewModel : BaseViewModel
    {
        /// <summary>
        /// The local file path to the user's profile picture
        /// </summary>
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// The username of the recepient
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The last message sent by either party
        /// </summary>
        public string LastMessage { get; set; }

        /// <summary>
        /// The time the other user was seen online. Could be <see cref="DateTimeOffset.MinValue"/>
        /// if the user hides his last seen
        /// </summary>
        public DateTimeOffset LastSeenTime { get; set; } = DateTimeOffset.MinValue;

        /// <summary>
        /// A user friendly <see cref="LastSeenTime"/>
        /// </summary>
        public string LastSeenTimeString => LastSeenTime.DateTime.ToShortTimeString();

        /// <summary>
        /// The time the last message in the conversation was sent.
        /// </summary>
        public DateTimeOffset LastMessageTime { get; set; }

        /// <summary>
        /// A user friendly <see cref="LastMessageTime"/>
        /// </summary>
        public string LastMessageTimeString => LastMessageTime.DateTime.ToShortTimeString();

        /// <summary>
        /// The time the last message in the conversation was read if it was not sent by me.
        /// </summary>
        public DateTimeOffset? MessageReadTime { get; set; }

        /// <summary>
        /// A user friendly <see cref="MessageReadTime"/>
        /// </summary>
        public string ReadTimeString => MessageReadTime?.DateTime.ToShortTimeString();

        /// <summary>
        /// <see langword="true"/> if the message has been opened by the receiving end.
        /// </summary>
        public bool IsRead { get; set; }
        
        /// <summary>
        /// The number of unread messages by the user
        /// </summary>
        public int UnreadCount { get; set; }

        /// <summary>
        /// True if there are any unread messages
        /// </summary>
        public bool HasUnreadMessage => UnreadCount > 0;
    }
}
