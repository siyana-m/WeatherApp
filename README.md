# OpenWeatherApp

## Overview

This project is a mobile application designed to provide weather forecasts. The IDE used is Visual Studio 2022, and the programming language used is C#. This repository contains the source code and resources required to compile and run the application using .NET 7 and MAUI.

## Directory Structure

The project is structured as follows:


```
OpenWeatherApp/
├── Dependencies/
├── Properties/
├── Platforms/
├── Resources/
├── App.xaml
├── AppShell.xaml
├── Constants.cs
├── FahrenheitToCelciusConverter.cs
├── ForecastData.cs
├── LongToDateTimeConverter.cs
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
├── RestService.cs
├── WeatherData.cs
├── WeatherTolmageConverter.cs
├── WeatherViewModel.cs
└── README.md
```


### Key Directories and Files

- **App.xaml**: Defines the application resources and styles.
- **AppShell.xaml**: Sets up the application’s navigation structure.
- **Constants.cs**: Contains constant values used across the application.
- **FahrenheitToCelciusConverter.cs**: Converts temperature from Fahrenheit to Celsius.
- **ForecastData.cs**: Models the weather forecast data.
- **LongToDateTimeConverter.cs**: Converts Unix timestamp to DateTime.
- **MainPage.xaml**: Defines the UI layout for the main page.
- **MainPage.xaml.cs**: Code-behind file for MainPage.xaml.
- **MauiProgram.cs**: Configures the MAUI application.
- **RestService.cs**: Handles API calls to fetch weather data.
- **WeatherData.cs**: Models the current weather data.
- **WeatherTolmageConverter.cs**: Converts weather data to corresponding images.
- **WeatherViewModel.cs**: Contains the logic for the weather data and binds it to the UI.
- **README.md**: The readme file you are currently reading.

## Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [MAUI](https://docs.microsoft.com/en-us/dotnet/maui/get-started/installation)

## Setup and Installation

1. **Clone the repository:**
    ```sh
    git clone https://github.com/siyana-m/OpenWeatherApp.git
    cd OpenWeatherApp
    ```

2. **Open the project in Visual Studio 2022:**
    - Open Visual Studio 2022.
    - Go to `File` > `Open` > `Project/Solution` and select the `OpenWeatherApp.sln` file.

3. **Build the project:**
    - Go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

4. **Run the application:**
    - Press `F5` or go to `Debug` > `Start Debugging`.

## Running the Application

When you run the application, it will display the current weather and forecast for a selected location. You can search for different locations to get their weather updates.

## Contributing

Contributions are welcome! Please create an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Contact

For any questions or feedback, please contact siskataam32@gmail.com.

## Notes

The project is a simple example of a weather forecast application. There may be more efficient or feature-rich ways to fetch and display weather data.

