using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoteriaApp.Converters
{
    public class ItemTappedEventArgsConverter : IValueConverter
    { 
      public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var itemTappedEventArgs = value as ItemTappedEventArgs;
        if (itemTappedEventArgs == null)
        {
            throw new ArgumentException("Expected value to be of type ItemTappedEventArgs", nameof(value));
        }
        return itemTappedEventArgs.Item;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}
}
