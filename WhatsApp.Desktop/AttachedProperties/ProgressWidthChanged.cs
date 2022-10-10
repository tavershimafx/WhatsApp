using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Linq;

namespace WhatsApp.Desktop
{
    public class ProgressWidthChanged : BaseAttachedProperty<ProgressWidthChanged, int>
    {
        private bool isFirstLoad = true;
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not Border element)
                return;

            var parent = (Border)VisualTreeHelper.GetParent(element);
            if (isFirstLoad)
            {
                RoutedEventHandler loaded = null;
                loaded += (ss, ee) =>
                {
                    loaded -= loaded;

                    SetWidth(element, parent.ActualWidth, e.NewValue);
                    isFirstLoad = false;
                };

                parent.Loaded += loaded;
            }
            else
                SetWidth(element, parent.ActualWidth, e.NewValue);
        }

        private void SetWidth(Border element, double parentWidth, object width)
        {
            double percentWidth = double.Parse(width.ToString()) / 100 * parentWidth;

            Task.Delay(3000); element.Width = 0;
            element.Width += percentWidth;
        }
    }
}
