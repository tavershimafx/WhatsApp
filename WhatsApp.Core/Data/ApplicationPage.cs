namespace WhatsApp.Core
{
    public enum ApplicationPage
    {
        Login = 0,

        Register = 1,

        Chat = 2,

        Settings = 3
    }

    /// <summary>
    /// Entry animation type
    /// </summary>
    public enum EntryAnimation
    {
        None = 0,

        SlideInFromRight = 1,

        SlideInFromLeft = 2,

        SlideInFromBottom = 3,

        SlideInFromTop = 4
    }

    /// <summary>
    /// Exit animation type
    /// </summary>
    public enum ExitAnimation
    {
        None = 0,

        SlideOutToRight = 1,

        SlideOutToLeft = 2,

        SlideOutToBottom = 3,

        SlideOutToTop = 4
    }
}
