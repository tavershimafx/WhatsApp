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

    public class SlideInAndOutToRightProperty : FrameworkElementBaseAnimation<SlideInAndOutToRightProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromRight(IsFirstLoad ? 0 : 0.6f);
            else
                element.SlideAndFadeOutToRight(IsFirstLoad ? 0 : 0.6f);
        }
    }

    public class SlideInFromLeftProperty : FrameworkElementBaseAnimation<SlideInFromLeftProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromLeft(IsFirstLoad ? 0 : 0.5f);
            else
                element.SlideAndFadeOutToLeft(IsFirstLoad ? 0 : 0.5f);
        }
    }
}
