using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using WhatsApp.Core;

namespace WhatsApp.Desktop
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        public BaseControl CurrentPage
        {
            get { return (BaseControl)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BaseControl), 
                typeof(PageHost),
                new UIPropertyMetadata(default, 
                    new PropertyChangedCallback(PageChanged)));

        private static void PageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var oldFrame = (d as PageHost).OldFrame;
            var newFrame = (d as PageHost).NewFrame;

            // Swap the contents of the new frame to the old frame and 
            // animate the old frame out
            if (newFrame.Content is not null)
                oldFrame.Content = (newFrame.Content as BaseControl).ShouldAnimateOut = true;

            // dispose the contents of the new page for fresh content
            newFrame.Content = null;

            // animate the old frame out
            if (oldFrame.Content is BaseControl old)
                old.AnimateOut();

            // set the content of the new frame to the page which it was switched to
            newFrame.Content = e.NewValue;
        }

        public PageHost()
        {
            InitializeComponent();

            if (DesignerProperties.GetIsInDesignMode(this))
            {
                CurrentPage = (BaseControl) new ApplicationPageConverter().Convert(ApplicationPage.Login, null, null, null);
            }
        }
    }
}
