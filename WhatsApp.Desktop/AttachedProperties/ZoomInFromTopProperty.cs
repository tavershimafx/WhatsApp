using System.Windows;
using WhatsApp.Desktop.Extensions;

namespace WhatsApp.Desktop
{
    /// <summary>
    /// An attachment property for zooming in and out an element from the top of the screen
    /// </summary>
    public class ZoomInFromTopProperty : FrameworkElementBaseAnimation<ZoomInFromTopProperty>
    {
        public override void DoAnimation(FrameworkElement element, object value)
        {
            if ((bool)value)
                element.AddZoomAndFadeInFromTop(IsFirstLoad ? 0 : 0.2f);
            else
                element.AddZoomAndFadeOutToTop(IsFirstLoad ? 0 : 0.1f);
        }
    }
}
