using System;
using System.Globalization;
using System.Windows.Media;
using WhatsApp.Core;

namespace WhatsApp.Desktop
{
    public class ApplicationPageConverter : BaseValueConverter<ApplicationPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not ApplicationPage page)
                return null;

            return page switch
            {
                ApplicationPage.Login => new Login(),
                ApplicationPage.Register => new Register(),
                ApplicationPage.Chat => new ChatPage(),
                ApplicationPage.Settings => null,
                _ => null,
            };
        }
    }
}
