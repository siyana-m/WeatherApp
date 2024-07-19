using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenWeatherApp
{
    public class ForecastData
    {
        [JsonProperty("list")]
        public List<Detail> List { get; set; } = new List<Detail>();

        [JsonProperty("city")]
        public ForecastCity City { get; set; }

        public class Detail
        {
            [JsonProperty("dt")]
            public long DtTxt { get; set; }

            [JsonProperty("main")]
            public Main Main { get; set; }

            [JsonProperty("weather")]
            public List<Weather> Weather { get; set; } = new List<Weather>();

            [JsonProperty("wind")]
            public Wind Wind { get; set; }
        }

        public class Main
        {
            [JsonProperty("temp")]
            public double Temp { get; set; }

            [JsonProperty("feels_like")]
            public double FeelsLike { get; set; }

            [JsonProperty("temp_min")]
            public double TempMin { get; set; }

            [JsonProperty("temp_max")]
            public double TempMax { get; set; }

            [JsonProperty("pressure")]
            public int Pressure { get; set; }

            [JsonProperty("humidity")]
            public int Humidity { get; set; }
        }

        public class Weather
        {
            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        public class Wind
        {
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("deg")]
            public int Deg { get; set; }
        }

        public class ForecastCity
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("coord")]
            public Coord Coord { get; set; }
        }

        public class Coord
        {
            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lon")]
            public double Lon { get; set; }
        }
    }
}
