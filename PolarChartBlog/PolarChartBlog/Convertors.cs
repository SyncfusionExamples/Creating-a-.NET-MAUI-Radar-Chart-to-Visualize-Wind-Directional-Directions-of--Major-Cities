using System.Globalization;


namespace PolarChartBlog
{
    public class StringConvertor : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is ClimateData data)
            {
                var direction = string.Empty;
                if (data.Direction == "East" || data.Direction == "North" || data.Direction == "South" || data.Direction == "West")
                {
                    direction = string.Concat(data.Direction, "\u00A0", "\u00A0", "\u00A0", ":", "\u00A0", "\u00A0");
                }
                else
                {
                    direction = data.Direction + "\u00A0" +":";
                }

                double brasilia = data.Brasilia;
                double tokyo = data.Tokyo;
                double london = data.London;
                double nairobi = data.Nairobi;

                if (brasilia != 0) return direction  +"\u00A0" + brasilia;
                if (tokyo != 0) return direction +"\u00A0" + tokyo;
                if (london != 0) return direction  + "\u00A0" + london;
                if (nairobi != 0) return direction  + "\u00A0" + nairobi;

                return direction;

            }

            return null;

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class FillConvertor : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is ClimateData data)
            {
                double brasilia = data.Brasilia;
                double tokyo = data.Tokyo;
                double london = data.London;
                double nairobi = data.Nairobi;

                if (brasilia != 0) return data.SolidColorBrush;
                if (tokyo != 0) return data.SolidColorBrush;
                if (london != 0) return data.SolidColorBrush;
                if (nairobi != 0) return data.SolidColorBrush;
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class CountryConvertor : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (value is ClimateData data)
            {
                double brasilia = data.Brasilia;
                double tokyo = data.Tokyo;
                double london = data.London;
                double nairobi = data.Nairobi;

                if (brasilia != 0) return "Brasilia";
                if (tokyo != 0) return "Tokyo";
                if (london != 0) return "London";
                if (nairobi != 0) return "Nairobi";

            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
