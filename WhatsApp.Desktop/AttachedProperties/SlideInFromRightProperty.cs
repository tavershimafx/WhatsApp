using System.Threading.Tasks;
using System.Windows;
using WhatsApp.Desktop.Extensions;

namespace WhatsApp.Desktop
{
    public class SlideInFromRightProperty : FrameworkElementBaseAnimation<SlideInFromRightProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromRight();
            else
                element.SlideAndFadeOutToLeft(width: Application.Current.MainWindow.Width);
        }
    }
}
