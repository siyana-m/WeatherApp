using Microsoft.Maui.Platform;
using System;
using System.Globalization;
using System.Diagnostics;

namespace OpenWeatherApp
{
    public class LongToDateTimeConverter : IValueConverter
    {
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is long unixTime)
            {
                try
                {
                    if (unixTime == 0)
                    {
                        return epoch.ToString("g", culture);
                    }

                    DateTime dateTime = epoch.AddSeconds(unixTime);
                    if (dateTime < epoch)
                    {
                        Debug.WriteLine("Handling date before Unix epoch.");
                    }
                    return dateTime.ToLocalTime().ToString("g", culture);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Debug.WriteLine($"Out of range exception converting timestamp: {e.Message}");
                    return "Date out of range";
                }
            }
            else if (value == null)
            {
                return "No timestamp provided";
            }

            Debug.WriteLine("Invalid data type for timestamp conversion.");
            return "Invalid data type";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
