# WeatherApp

WeatherApp is a Windows Forms application that provides current and forecast weather information for a city entered by the user. Users can search for the weather of a specific city and refresh the data to stay up to date with the latest weather details.

## Features

- **Search for weather:** Enter the name of a city and click the "Search" button to retrieve current and 5-day forecast weather information.
- **Update weather data:** Click the "Refresh" button to update the weather information for the current city.
- **Display weather details:** View temperature, weather descriptions, and forecasted weather for the next few days.
- **User-friendly interface:** A clean interface with a background image and a scrollable layout to display weather data.

## Installation

To run WeatherApp, follow these steps:

1. Clone or download the project repository.
2. Open the solution file `WeatherApp.sln` in Visual Studio.
3. Build the solution by pressing `Ctrl+Shift+B`.
4. Run the project by pressing `F5` or clicking the "Start" button in Visual Studio.

## Requirements

- Microsoft Visual Studio
- .NET Framework 4.7.2 or higher
- An API key for OpenWeatherMap (free tier)

## How to Use

1. **Search for a city's weather:**
   - Open the application.
   - Enter the name of a city in the input field.
   - Click the **"Search"** button to fetch the current weather and 5-day forecast for the entered city.
   - The app will display the weather details, including temperature, weather description (e.g., "clear sky"), and date.

2. **Refresh the weather data:**
   - Click the **"Refresh"** button to update the weather information for the current city.

3. The weather data will be shown in a flow layout panel, and users can scroll through the results.

## Weather API Integration

- The app retrieves weather data using the **OpenWeatherMap API**.
- The weather information includes:
  - **Temperature** (in Celsius)
  - **Weather description** (e.g., "clear sky")
  - **Date** for each forecast

**Note:** To use the app, you'll need to replace `"Your-Api-key"` in the `GetWeather` class with your own OpenWeatherMap API key. You can get an API key by signing up for a free account at [OpenWeatherMap](https://openweathermap.org/).
