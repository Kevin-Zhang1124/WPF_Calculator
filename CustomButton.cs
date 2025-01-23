using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace calculator
{
    public class CustomButton:Button
    {
        // 依赖属性

        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register("ButtonCornerRadius", typeof(CornerRadius), typeof(CustomButton));



        public Brush BackgroundHover
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register("BackgroundHover", typeof(Brush), typeof(CustomButton));




        public Brush BackgroundPressed
        {
            get { return (Brush)GetValue(BackgroundPressedProperty); }
            set { SetValue(BackgroundPressedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundPressed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundPressedProperty =
            DependencyProperty.Register("BackgroundPressed", typeof(Brush), typeof(CustomButton));



    }
}
