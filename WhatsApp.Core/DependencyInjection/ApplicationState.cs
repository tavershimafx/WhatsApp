
namespace WhatsApp.Core
{
    public class ApplicationState : BaseViewModel
    {
        /// <summary>
        /// True if the user is successfully authenticated to the server
        /// </summary>
        public bool IsLoggedIn => !string.IsNullOrEmpty(SessionToken);

        /// <summary>
        /// True if the user is successfully authenticated to the server and has network
        /// connectivity available to make requests to the server
        /// </summary>
        public bool IsOnline { get; set; } = false;

        /// <summary>
        /// The token used to authenticate the user to the server
        /// </summary>
        public string SessionToken { get; set; }

        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        public void NavigateToPage(ApplicationPage page)
        {
            CurrentPage = page;
        }
    }
}
