using System;
using System.Globalization;
using System.Windows;

namespace WhatsApp.Desktop
{
    public class IsReadToForegroundConverter : BaseValueConverter<IsReadToForegroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return Application.Current.FindResource("IsReadBlueBrush");
            else
                return Application.Current.FindResource("DarkGrayBrush");
        }
    }
}
