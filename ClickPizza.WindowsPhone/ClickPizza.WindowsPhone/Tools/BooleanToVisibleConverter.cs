using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ClickPizza.WindowsPhone.Tools
{
    public class BooleanToVisibleConverter: IValueConverter
    {
        public bool IsInverted { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((value is bool) && (bool)value) ^ IsInverted ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
