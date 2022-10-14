using System.Collections.ObjectModel;
using WhatsApp.Core.ViewModels.Enums;

namespace WhatsApp.Core
{
    public class SeedData
    {
        public static SideMenuViewModel SideMenu()
        {
            return new SideMenuViewModel() { RecentChats = RecentChatList() };
        }

        public static RecentChatListViewModel RecentChatList()
        {
            return new RecentChatListViewModel { Items = RecentChats() };
        }

        public static ObservableCollection<RecentChatViewModel> RecentChats()
        {
            return new ObservableCollection<RecentChatViewModel>()
            {
                new RecentChatDesignModel()
                {
                    Username = "Shiphrah",
                    ProfilePictureUrl = "Resources/Images/shiphrah.jpg",
                    LastMessage = "Hello Shiphrah, I just want to say Happy birthday.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = false,
                    UnreadCount = 3
                },
                new RecentChatDesignModel()
                {
                    Username = "Kosi",
                    ProfilePictureUrl = "Resources/Images/kosi.jpg",
                    LastMessage = "Let me continue my crushing.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = false,
                    UnreadCount = 5
                },
                new RecentChatDesignModel()
                {
                    Username = "Ikenna",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "I have been trying to make the action work but seems not to be working.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                },
                new RecentChatDesignModel()
                {
                    Username = "Olaoye",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "Okay boss.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                },
                new RecentChatDesignModel()
                {
                    Username = "Anita",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "Hey babe, how have you been?",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                },
                new RecentChatDesignModel()
                {
                    Username = "C#.Net Jobs and discussions",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "Oga, no be so oooo.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                },
                new RecentChatDesignModel()
                {
                    Username = "GDG Mpape",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "+234 8033890976 joined using this group link.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                },
                new RecentChatDesignModel()
                {
                    Username = "MSFT TECH COMMUNITY FUTO",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "Samson: 7 years back.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                },
                new RecentChatDesignModel()
                {
                    Username = "Zinabe Stephen",
                    ProfilePictureUrl = "Resources/Images/user.png",
                    LastMessage = "So how e go be naw?.",
                    LastSeenTime = DateTimeOffset.Now,
                    LastMessageTime = DateTimeOffset.Now,
                    MessageReadTime = DateTimeOffset.Now,
                    IsRead = true
                }
            };
        }

        public static RecentChatViewModel RecentChatItem()
        {
            return new RecentChatViewModel()
            {
                Username = "Shiphrah",
                ProfilePictureUrl = "/Resources/Images/shiphrah.jpg",
                LastMessage = "Hello Shiphrah, I just want to say Happy birthday. I lack logical expressions to present to you but...",
                LastSeenTime = DateTimeOffset.Now,
                LastMessageTime = DateTimeOffset.Now,
                MessageReadTime = DateTimeOffset.Now,
                IsRead = false
            };
        }

        public static ChatMessageListViewModel ChatMessageList()
        {
            return new ChatMessageListViewModel 
            { 
                Username = "Kosi",
                ProfilePictureUrl = "Resources/Images/kosi.jpg",
                Items = ChatMessages() 
            };
        }

        public static ObservableCollection<ChatMessageViewModel> ChatMessages()
        {
            return new ObservableCollection<ChatMessageViewModel>
            {
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = " What are you even saying? I don't understand ooo",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "See fine guy nau",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "Close your eyes",
                    SentByMe = true,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "I like good things abeg",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "Its wide open",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "Subscribe to LinkedIn premium let me connect you",
                    SentByMe = true,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "I don't have money",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "You're playing with grace",
                    SentByMe = true,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "You can alway connect without the premium thing",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "LinkedIn doesn't show people who viewed your profile without premium ooo",
                    SentByMe = true,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "I don't need it ooo",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "Why are we connecting through LinkedIn sef",
                    SentByMe = false,
                    MessageSentTime = DateTime.Now
                },
                new ChatMessageViewModel
                {
                    MessageType = MessageType.Text,
                    Message = "I'm the LinkedIn",
                    SentByMe = true,
                    MessageSentTime = DateTime.Now
                }
            };
        }
    }
}
