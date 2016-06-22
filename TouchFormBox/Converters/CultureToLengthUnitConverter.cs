namespace TouchFormBox.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;
    using Gu.Units;

    public class CultureToLengthUnitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cultureInfo = (CultureInfo) value;
            if (cultureInfo.TwoLetterISOLanguageName == "en")
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
