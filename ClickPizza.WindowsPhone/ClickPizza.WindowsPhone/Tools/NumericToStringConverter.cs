using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Data;

namespace ClickPizza.WindowsPhone.Tools
{

    public class NumericToStringConverter :IValueConverter
    {
        private const string length = " см";
        private const string weight = " г";

        // Summary:
        //     Modifies the source data before passing it to the target for display in the
        //     UI.
        //
        // Parameters:
        //   value:
        //     The source data being passed to the target.
        //
        //   targetType:
        //     The System.Type of data expected by the target dependency property.
        //
        //   parameter:
        //     An optional parameter to be used in the converter logic.
        //
        //   culture:
        //     The culture of the conversion.
        //
        // Returns:
        //     The value to be passed to the target dependency property.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (parameter as string)
            {
                case "Length"   :
                    return value + length;
                case "Weight"   :
                    return value + weight;
                case "Price"    :
                    return String.Format("{0:C0}", value);
                default : 
                    throw new InvalidDataContractException();
            }
        }
        //
        // Summary:
        //     Modifies the target data before passing it to the source object. This method
        //     is called only in System.Windows.Data.BindingMode.TwoWay bindings.
        //
        // Parameters:
        //   value:
        //     The target data being passed to the source.
        //
        //   targetType:
        //     The System.Type of data expected by the source object.
        //
        //   parameter:
        //     An optional parameter to be used in the converter logic.
        //
        //   culture:
        //     The culture of the conversion.
        //
        // Returns:
        //     The value to be passed to the source object.
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
