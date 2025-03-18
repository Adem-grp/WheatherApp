using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WheatherApp
{
    public class WeatherData
    {
        // Manually convert Unix timestamp to DateTime
        public long Dt { get; set; }  // Unix timestamp for forecast
        public DateTime Date => DateTimeOffset.FromUnixTimeSeconds(Dt).DateTime;  // Convert Unix timestamp to DateTime
        public MainData Main { get; set; }  // Temperature info
        public List<WeatherDescription> Weather { get; set; }  // Weather description
    }

    public class MainData
    {
        public double Temp { get; set; }  // Temperature in Celsius
    }

    public class WeatherDescription
    {
        public string Description { get; set; }  // Weather description (e.g., "clear sky")
    }

    public class WeatherResponse
    {
        public List<WeatherData> List { get; set; }  
    }

    class GetWeather
    {
        public static async Task<List<string>> GetWeatherAsync(string city)
        {
            string ApiKey = "Your-Api-key";  // Replace with your actual API key

            // URL for 5-day, 3-hour forecast (this is for the free plan)
            string url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={ApiKey}&units=metric";

            List<string> report = new List<string>();
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Sending request to: " + url); // Log the request URL
                HttpResponseMessage response = await client.GetAsync(url);
                Console.WriteLine("Response Status Code: " + response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response Content: " + jsonResponse); // Log the response content

                    // Deserialize the response into the WeatherResponse object
                    WeatherResponse weather_Response = JsonConvert.DeserializeObject<WeatherResponse>(jsonResponse);

                    // Group by date and take the first forecast for each day
                    var dailyForecasts = weather_Response.List
                        .GroupBy(x => x.Date.Date)  // Group by the date (ignoring time)
                        .Select(g => g.FirstOrDefault())  // Get the first forecast of each day
                        .Take(5)  // Limit to 5 days
                        .ToList();

                    // Process the daily forecasts
                    foreach (var day in dailyForecasts)
                    {
                        string date = day.Date.ToString("yyyy-MM-dd");
                        string temp = day.Main.Temp.ToString("0.0") + "°C";
                        string description = day.Weather[0].Description;
                        report.Add($"Date: {date} | Temp: {temp} | Weather: {description}");
                    }

                    return report;
                }
                else
                {
                    List<string> error = new List<string> { "City not found" };
                    return error;
                }
            }
        }
    }
}
