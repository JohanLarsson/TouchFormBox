using System;
using System.Globalization;
using System.Windows.Data;
using Gu.Units;

namespace TouchFormBox.Converters
{
    public class CultureToLengthUnitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cultureInfo = (CultureInfo) value;
            if (cultureInfo.TwoLetterISOLanguageName == "us")
            {
                return LengthUnit.Inches;
            }

            return LengthUnit.Centimetres;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
