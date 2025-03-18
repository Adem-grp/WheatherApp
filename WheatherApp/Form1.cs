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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            
        }

        private void Form1_Load(object sender, EventArgs e){}
        private async void  buttonSearch_Click(object sender, EventArgs e)
        {
            string city_name= textBox1.Text;
            if (!string.IsNullOrEmpty(city_name))
            {
                List<string> weatherinfo = await GetWeather.GetWeatherAsync(city_name);
                if(weatherinfo[0] =="City not found")
                {
                    MessageBox.Show("City not found");
                    return;

                }
                CityWeather cityWeather = new CityWeather(weatherinfo,city_name);
                cityWeather.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a city name");
            }
            
        }
    }
}
