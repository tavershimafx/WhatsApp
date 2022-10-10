using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace WhatsApp.Desktop
{
    public class RGBStringToBrushConverter : BaseValueConverter<RGBStringToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush) new BrushConverter().ConvertFromString($"#{value}");
        }
    }
}
