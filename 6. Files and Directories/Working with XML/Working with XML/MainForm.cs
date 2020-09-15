using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Working_with_XML
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

 

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            WeatherForecastWithPOCOs weatherForecastWithPOCOs = new WeatherForecastWithPOCOs();

            XmlSerializer xs = new XmlSerializer(typeof(WeatherForecastWithPOCOs));

            TextWriter txtWriter = new StreamWriter(@"WeatherForecastWithPOCOs.xml");

            xs.Serialize(txtWriter, weatherForecastWithPOCOs);

            txtWriter.Close();
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
