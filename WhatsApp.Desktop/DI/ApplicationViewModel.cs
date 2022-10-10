using WhatsApp.Core.DependencyInjection;
using WhatsApp.Core;
using System.Windows.Markup;

namespace WhatsApp.Desktop
{
    public class ApplicationViewModel
    {
        public static ApplicationViewModel Current { get; set; } = new();

        public static ApplicationState ApplicationState => ServiceContainer.GetRequiredService<ApplicationState>();
    }
}
