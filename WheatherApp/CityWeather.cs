using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheatherApp
{
    public partial class CityWeather: Form
    {
        private List<string> weather_Data;
        private string city_name;
        public  CityWeather(List<string> Weatherinfo, string cityname)
        {
            InitializeComponent();
            weather_Data =Weatherinfo;
            city_name = cityname;
            this.Load += new EventHandler(CityWeather_Load);
        }

        private void CityWeather_Load(object sender, EventArgs e)
        {
            DisplayWeatherInFlowLayout(weather_Data);
        }
        private void CityWeather_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit(); 
        }

        private void DisplayWeatherInFlowLayout(List<string> weatherInfo)
        {
           
            flowLayoutPanel1.Controls.Clear();

            // Iterate through the weather info list and display each day’s data
            foreach (string weatherData in weatherInfo)
            {
                // Create a panel for each weather day
                Panel panel = new Panel
                {
                    Width = flowLayoutPanel1.Width - 20, // Adjust the panel width
                    Height = 50, // Adjust the panel height
                    BorderStyle = BorderStyle.FixedSingle // Optional: To make it visible
                };

                // Create a label for the weather data
                Label weatherLabel = new Label
                {
                    Text = weatherData,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = true
                };

                
                panel.Controls.Add(weatherLabel);
                

                
                flowLayoutPanel1.Controls.Add(panel);
            }
        }
        private async void buttonRef_Click(object sender, EventArgs e)
        {
            List<string> updated_info = await GetWeather.GetWeatherAsync(city_name);
            if(updated_info.Contains( "City not found"))
            {
                MessageBox.Show("City not found");
                return;
            }
            else
            {
                weather_Data = updated_info;
                DisplayWeatherInFlowLayout(updated_info);
            }
        }

    }
}
