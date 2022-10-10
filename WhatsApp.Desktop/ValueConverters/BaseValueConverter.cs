using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace WhatsApp.Desktop
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T : BaseValueConverter<T>, new()
    {

        private T mConverter;
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter?? new T();
        }

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
