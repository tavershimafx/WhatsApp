using WhatsApp.Core.ViewModels.Enums;

namespace WhatsApp.Core
{
    //public interface IMessageContent
    //{
    //    Stream StreamContent { get; set; }
    //}
    public class MessageContent
    {

    }
    public class ChatMessageViewModel : BaseViewModel
    {
        /// <summary>
        /// The type of the message
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// The message sent. If <see cref="MessageType"/> is text, it is assigned to here
        /// directly otherwise represented as a <see cref="MessageObject"/>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// An object which represents the content of the message if other than <see cref="MessageType.Text"/>
        /// </summary>
        public MessageContent MessageObject { get; set; }

        /// <summary>
        /// The time the message was sent.
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }

        /// <summary>
        /// A user friendly <see cref="MessageSentTime"/>
        /// </summary>
        public string SentTimeString => MessageSentTime.DateTime.ToShortTimeString();

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
        public bool IsRead { get; set; } = true;

        /// <summary>
        /// Unicode for tick sign from lineicon fonts
        /// </summary>
        public string IsReadString => IsRead ? "\uea5b\uea5b" : "\uea5b";

        /// <summary>
        /// A flag to determine if the message was sent by me
        /// </summary>
        public bool SentByMe { get; set; }

        /// <summary>
        /// The user Id of the sender
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// The direction to align the message in the container.
        /// </summary>
        public ElementHorizontalAlignment HorizontalAlignment => SentByMe ? ElementHorizontalAlignment.Right : ElementHorizontalAlignment.Left;
    }
}
