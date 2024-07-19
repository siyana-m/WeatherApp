using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

namespace OpenWeatherApp
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private DateTime sunrise;
        private DateTime sunset;
        private string dayNightImage;
        private System.Timers.Timer timer;

        public DateTime Sunrise
        {
            get => sunrise;
            set { sunrise = value; OnPropertyChanged(); }
        }

        public DateTime Sunset
        {
            get => sunset;
            set { sunset = value; OnPropertyChanged(); }
        }

        public string DayNightImage
        {
            get => dayNightImage;
            set
            {
                if (dayNightImage != value)
                {
                    dayNightImage = value;
                    OnPropertyChanged();
                }
            }
        }

        public WeatherViewModel()
        {
            DayNightImage = "after_noon.png";
            timer = new System.Timers.Timer(60000); // Fire every 30 seconds
            timer.Elapsed += (sender, e) => UpdateDayNightImage();
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateDayNightImage();
        }

        private void UpdateDayNightImage()
        {
            var currentTime = DateTime.Now;
            if (currentTime >= Sunrise && currentTime < Sunset)
                DayNightImage = "after_noon.png"; 
            else
                DayNightImage = "night.png";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
