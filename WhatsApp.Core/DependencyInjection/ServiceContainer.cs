using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsApp.Core.DependencyInjection
{
   
    public class ServiceContainer 
    {
        public static IKernel GlobalKernel { get; private set; } = new StandardKernel();

        public static void Configure()
        {

            // Configure all the services needed for the application
            ConfigureServices();
        }

        private static void ConfigureServices()
        {
            GlobalKernel.Bind<ApplicationState>().ToConstant(new ApplicationState());
        }

        public static T GetRequiredService<T>()
        {
            return GlobalKernel.Get<T>();
        }

        public static ApplicationState ApplicationState => GetRequiredService<ApplicationState>();
    }
}
