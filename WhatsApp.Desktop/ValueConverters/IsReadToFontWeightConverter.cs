using System;
using System.Globalization;
using System.Windows;

namespace WhatsApp.Desktop
{
    public class IsReadToFontWeightConverter : BaseValueConverter<IsReadToFontWeightConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? FontWeights.Normal : FontWeights.Bold;
        }
    }
}
