using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace OpenWeatherApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private RestService _restService;
        private WeatherData _weatherData;
        private ForecastData _forecastData;
        private string _currentDate = DateTime.Now.ToString("MMMM dd, hh:mmtt");

        public WeatherData WeatherData
        {
            get => _weatherData;
            set
            {
                if (_weatherData != value)
                {
                    _weatherData = value;
                    OnPropertyChanged();
                }
            }
        }

        public ForecastData ForecastData
        {
            get => _forecastData;
            set
            {
                if (_forecastData != value)
                {
                    _forecastData = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CurrentDate
        {
            get => _currentDate;
            set
            {
                if (_currentDate != value)
                {
                    _currentDate = value;
                    OnPropertyChanged();
                }
            }
        }

        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            _restService = new RestService();

            Device.StartTimer(TimeSpan.FromMinutes(1), () =>
            {
                CurrentDate = DateTime.Now.ToString("MMMM dd, hh:mmtt");
                return true;
            });

            var testTimestamp = 1609459200;
            var testDate = new LongToDateTimeConverter().Convert(testTimestamp, null, null, CultureInfo.CurrentCulture);
            Debug.WriteLine("Converted test timestamp: " + testDate);
        }

        async void OnGetWeatherButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_cityEntry.Text))
            {
                try
                {
                    WeatherData = await _restService.GetWeatherData(GenerateRequestURL(Constants.OpenWeatherMapEndpoint));
                    if (WeatherData != null && WeatherData.Coord != null)
                    {
                        ForecastData = await _restService.GetForecastData(WeatherData.Coord.Lat, WeatherData.Coord.Lon, Constants.OpenWeatherMapAPIKey);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Failed to fetch weather data: " + ex.Message);
                }
            }
        }

        string GenerateRequestURL(string endPoint)
        {
            return $"{endPoint}?q={_cityEntry.Text}&units=imperial&APPID={Constants.OpenWeatherMapAPIKey}";
        }
    }
}
