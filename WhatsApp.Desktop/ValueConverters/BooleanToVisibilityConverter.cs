using System;
using System.Globalization;
using System.Windows;

namespace WhatsApp.Desktop
{
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)parameter == "Inverse")
                return (bool)value? Visibility.Collapsed: Visibility.Visible;
            else
                return(bool)value? Visibility.Visible: Visibility.Collapsed;
        }
    }
}
