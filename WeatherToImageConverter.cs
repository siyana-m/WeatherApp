using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace OpenWeatherApp
{
    public class WeatherToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            string condition = value.ToString().ToLower();

            var now = DateTime.Now;
            bool isDayTime = now.Hour >= 6 && now.Hour < 18;
            string timeSuffix = isDayTime ? "_d" : "_n";

            switch (condition)
            {
                case "clear sky":
                    return $"Resources/Images/clear{timeSuffix}.png";
                case "few clouds":
                    return $"Resources/Images/few{timeSuffix}.png";
                case "scattered clouds":
                    return $"Resources/Images/scattered{timeSuffix}.png";
                case "broken clouds":
                    return $"Resources/Images/broken{timeSuffix}.png";
                case "shower rain":
                    return $"Resources/Images/shower{timeSuffix}.png";
                case "rain":
                    return $"Resources/Images/rain{timeSuffix}.png";
                case "thunderstorm":
                    return $"Resources/Images/thunder{timeSuffix}.png";
                case "snow":
                    return $"Resources/Images/snow{timeSuffix}.png";
                case "mist":
                    return $"Resources/Images/mist{timeSuffix}.png";
                case "overcast clouds":
                    return $"Resources/Images/broken{timeSuffix}.png";
                case "light rain":
                    return $"Resources/Images/rain{timeSuffix}.png";
                case "moderate rain":
                    return $"Resources/Images/rain{timeSuffix}.png";
                default:
                    return "Resources/Images/dotnet_bot.svg";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
