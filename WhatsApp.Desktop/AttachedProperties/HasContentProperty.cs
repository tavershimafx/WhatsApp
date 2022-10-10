using System.Windows;
using System.Windows.Controls;

namespace WhatsApp.Desktop
{
    public class ContentChangedProperty : BaseAttachedProperty<ContentChangedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textbox)
            {
                if ((bool)e.NewValue)
                {
                    textbox.TextChanged += Textbox_TextChanged;
                }
            }
        }

        private void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            HasContentProperty.SetValue(sender as DependencyObject);
        }
    }

    public class HasContentProperty : BaseAttachedProperty<HasContentProperty, bool>
    {
        public static void SetValue(DependencyObject d)
        {
            SetValue(d, ((TextBox)d).Text.Length > 0);
        }
    }

    public class RevealPasswordProperty : BaseAttachedProperty<RevealPasswordProperty, bool>
    {
        public static void SetValue(DependencyObject d)
        {
            SetValue(d, ((TextBox)d).Text.Length > 0);
        }
    }
}
