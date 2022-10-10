using System;
using System.Globalization;
using System.Windows;

namespace WhatsApp.Desktop
{
    public class SentByMeToBackgroundConverter : BaseValueConverter<SentByMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return Application.Current.FindResource("WhatsAppLightGreenBrush");
            else
                return Application.Current.FindResource("LightBrush");
        }
    }
}
