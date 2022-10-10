using System;
using System.Globalization;
using System.Windows;

namespace WhatsApp.Desktop
{
    public class ElementHorizontalAlignmentConverter : BaseValueConverter<ElementHorizontalAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (HorizontalAlignment)value;
        }
    }
}
