using System.Windows;

namespace WhatsApp.Desktop
{
    /// <summary>
    /// A base class for <see cref="FrameworkElement"/> animation attached property
    /// </summary>
    public abstract class FrameworkElementBaseAnimation<Parent> : BaseAttachedProperty<Parent, bool> where Parent: class, new()
    {
        /// <summary>
        /// A hack to wait for the element to load so we can get its dimensions. The fact is
        /// when the element is not yet loaded into the screen, its width or height is not yet
        /// known, so trying to perform a slide animation will yield futile
        /// </summary>
        public bool IsFirstLoad { get; set; } = true;

        public override void OnValueUpdated(DependencyObject d, object value)
        {
            if (d is not FrameworkElement element)
                return;

            if (IsFirstLoad)
            {
                RoutedEventHandler loaded = null;
                loaded = (sender, e) =>
                {
                    loaded -= loaded;

                    DoAnimation(element, value);

                    IsFirstLoad = false;
                };

                element.Loaded += loaded;
            }
            else
                DoAnimation(element, value);
        }

        public abstract void DoAnimation(FrameworkElement element, object value);
    }
}
