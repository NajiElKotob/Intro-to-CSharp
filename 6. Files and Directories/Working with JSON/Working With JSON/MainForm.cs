using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
Json.NET
Popular high-performance JSON framework for .NET
https://www.newtonsoft.com/json


How to serialize and deserialize (marshal and unmarshal) JSON in .NET
https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to

*/

namespace Working_With_JSON
{
    public partial class MainForm : Form
    {
        private string json;
        private WeatherForecastWithPOCOs weatherForecastWithPOCOs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            json = @"{
  'Date': '2019-08-01T00:00:00-07:00',
  'TemperatureCelsius': 25,
  'Summary': 'Hot',
  'DatesAvailable': [
    '2019-08-01T00:00:00-07:00',
    '2019-08-02T00:00:00-07:00'
  ],
  'TemperatureRanges': {
    'Cold': {
      'High': 20,
      'Low': -10
    },
    'Hot': {
      'High': 60,
      'Low': 20
    }
  },
  'SummaryWords': [
    'Cool',
    'Windy',
    'Humid'
  ]
}";

        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            weatherForecastWithPOCOs.Date = DateTime.Now;
            var jsonValue = JsonConvert.SerializeObject(weatherForecastWithPOCOs);

            txtOutput.Text = jsonValue;
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {



            weatherForecastWithPOCOs = JsonConvert.DeserializeObject<WeatherForecastWithPOCOs>(json);
            MessageBox.Show(weatherForecastWithPOCOs.Date.ToString());
            MessageBox.Show(string.Join(", ", weatherForecastWithPOCOs.SummaryWords));
            MessageBox.Show(((HighLowTemps)weatherForecastWithPOCOs.TemperatureRanges["Cold"]).Low.ToString());

        }


    }


    public class WeatherForecastWithPOCOs
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public string SummaryField;
        public IList<DateTimeOffset> DatesAvailable { get; set; }
        public Dictionary<string, HighLowTemps> TemperatureRanges { get; set; }
        public string[] SummaryWords { get; set; }
    }

    public class HighLowTemps
    {
        public int High { get; set; }
        public int Low { get; set; }
    }


}
