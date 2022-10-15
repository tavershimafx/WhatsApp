using System.Windows;
using WhatsApp.Desktop.Extensions;

namespace WhatsApp.Desktop
{
    public class SlideInFromBottomProperty : FrameworkElementBaseAnimation<SlideInFromBottomProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromBottom(IsFirstLoad ? 0 : 0.4f);
            else
                element.SlideAndFadeOutToBottom(IsFirstLoad ? 0 : 0.5f);
        }
    }

    public class SlideInFromTopProperty : FrameworkElementBaseAnimation<SlideInFromTopProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.SlideAndFadeInFromTop(IsFirstLoad ? 0 : 0.4f);
            else
                element.SlideAndFadeOutToTop(IsFirstLoad ? 0 : 0.9f);
        }
    }
}
