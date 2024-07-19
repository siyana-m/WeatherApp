using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace OpenWeatherApp
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(query);
                string content = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<WeatherData>(content);
                }
                else
                {
                    Debug.WriteLine($"API Error: {content}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in GetWeatherData: {ex}");
                throw;
            }
        }

        public async Task<ForecastData> GetForecastData(double lat, double lon, string apiKey)
        {
            string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={apiKey}&units=metric";
            HttpResponseMessage response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            Debug.WriteLine("API Response: " + content);
            if (response.IsSuccessStatusCode)
            {
                var forecastData = JsonConvert.DeserializeObject<ForecastData>(content);
                return forecastData;
            }
            else
            {
                Debug.WriteLine($"Failed to fetch forecast data: {response.StatusCode}");
                return null;
            }
        }
    }
}
