using System.Windows;
using WhatsApp.Desktop.Extensions;

namespace WhatsApp.Desktop
{
    public class SlideInFromLeftProperty : FrameworkElementBaseAnimation<SlideInFromLeftProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromLeft();
            else
            {
                element.SlideAndFadeOutToLeft(seconds: 0);
                //element.Visibility = Visibility.Collapsed;
            }
        }
    }
}
