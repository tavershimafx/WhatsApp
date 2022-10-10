namespace WhatsApp.Core
{
    public class ProgressBarDesignModel : ProgressBarViewModel
    {
        public static ProgressBarDesignModel Instance = new();

        public ProgressBarDesignModel()
        {
            Percent = 40;
            ProgressColor = "ff0000";
        }
    }
}
