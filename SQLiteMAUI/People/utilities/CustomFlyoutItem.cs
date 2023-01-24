using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.utilities
{
    public class CustomFlyoutItem : FlyoutItem
    {
        public static readonly BindableProperty ForegroundProperty = BindableProperty.Create(nameof(Foreground), typeof(Color), typeof(CustomFlyoutItem), default(Color));
        public Color Foreground
        {
            get
            {
                return (Color)GetValue(ForegroundProperty);
            }
            set
            {
                SetValue(ForegroundProperty, value);
            }
        }
    }
}
