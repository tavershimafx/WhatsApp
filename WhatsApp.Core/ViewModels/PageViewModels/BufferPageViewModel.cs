
namespace WhatsApp.Core
{
    public class BufferPageViewModel : BaseViewModel
    {

        #region Public Properties

        /// <summary>
        /// True if the app is downloading chats from the server
        /// </summary>
        public bool IsDownloadingChats { get; set; } = true;

        private int mPercent = 5;
        public int DownloadPercent { get
            {
                return mPercent;
            }
            set
            {
                mPercent = value;
                ProgressBar.Percent = value;
            }
        }

        public string DownloadPercentString => $"Loading your chats [{DownloadPercent}%]";

        public ProgressBarViewModel ProgressBar { get; set; }
        #endregion

        public BufferPageViewModel()
        {
            ProgressBar = new() { ProgressColor = "ff0000", Percent = DownloadPercent };

            // just to simulate loading
            Task.Run(async () =>
            {
                DownloadPercent = 0;
                await Task.Delay(4000);
                for (int i = 0; i < 100; i++)
                {
                    await Task.Delay(100);
                    DownloadPercent ++;
                }
            });
        }
    }
}