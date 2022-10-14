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
                element.SlideAndFadeInFromRight(IsFirstLoad? 0 : 0.9f);
            else
                element.SlideAndFadeOutToLeft(IsFirstLoad ? 0 : 0.9f);
        }
    }
}
