using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WhatsApp.Core.DependencyInjection;

namespace WhatsApp.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // configure dependency injection before starting the application
            ServiceContainer.Configure();

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }
    }
}
