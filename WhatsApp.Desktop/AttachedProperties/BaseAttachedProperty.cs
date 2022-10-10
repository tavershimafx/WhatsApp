using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WhatsApp.Desktop
{
    public abstract class BaseAttachedProperty<Parent, Property> where Parent : class, new()
    {
        public static Parent Instance = new Parent();

        public static Property GetValue(DependencyObject obj) => (Property)obj.GetValue(ValueProperty);

        public static void SetValue(DependencyObject obj, Property value) => obj.SetValue(ValueProperty, value);
        

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(Property), 
                typeof(BaseAttachedProperty<Parent, Property>), 
                new UIPropertyMetadata(default(Property),
                new PropertyChangedCallback(OnValuePropertyChanged),
                new CoerceValueCallback(OnValuePropertyUpdated)));

        private static object OnValuePropertyUpdated(DependencyObject d, object baseValue)
        {
            (Instance as BaseAttachedProperty<Parent, Property>).OnValueUpdated(d, baseValue);

            return baseValue;
        }

        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (Instance as BaseAttachedProperty<Parent, Property>).OnValueChanged(d, e);
        }

        public virtual void OnValueUpdated(DependencyObject d, object baseValue) { }

        public virtual void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e){}
    }
}
