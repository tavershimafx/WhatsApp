using System;
using System.Globalization;
using System.Windows;

namespace WhatsApp.Desktop
{
    public class ElementVerticalAlignmentConverter : BaseValueConverter<ElementVerticalAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (VerticalAlignment)value;
        }
    }
}
