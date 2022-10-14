using System.Windows;
using WhatsApp.Desktop.Extensions;

namespace WhatsApp.Desktop
{
    public class SlideInFromLeftProperty : FrameworkElementBaseAnimation<SlideInFromLeftProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromLeft(IsFirstLoad ? 0 : 0.9f);
            else
            {
                element.SlideAndFadeOutToLeft(IsFirstLoad ? 0 : 0.9f);
            }
        }
    }

    public class SlideInFromBottomProperty : FrameworkElementBaseAnimation<SlideInFromBottomProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromBottom(IsFirstLoad ? 0 : 0.4f);
            else
            {
                element.SlideAndFadeOutToBottom(IsFirstLoad ? 0 : 0.9f);
            }
        }
    }
}
