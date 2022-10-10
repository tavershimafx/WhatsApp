using System;
using System.Globalization;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WhatsApp.Desktop
{
    public class PathToImageConverter : BaseValueConverter<PathToImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string actualPath;
            var curDir = new DirectoryInfo(Directory.GetCurrentDirectory());
            if (curDir.Name == "net6.0-windows")
            {
                actualPath = $"pack://application:,,,/{value}";
            }
            else
            {
                actualPath = $"/Media/{value}";
            }

            return new BitmapImage(new Uri($"{actualPath}"));
        }
    }
}
