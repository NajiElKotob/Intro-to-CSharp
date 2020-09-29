using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureConversionLib;
using static TemperatureConversionLib.TemperatureConversion;

namespace Temperature_Conversion
{

    // T(°F) = T(°C) × 9/5 + 32

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConvertToTemperatureF_Click(object sender, EventArgs e)
        {
            //1. In click event - 0.5/10
            /*
            var c = double.Parse(txtTemperatureC.Text);
            var f = (c * 9/5) +32;

            lblOutput.Text = f.ToString();
            */

            //2. Method (function) 
            //lblOutput.Text = ConvertToFahrenheit(double.Parse(txtTemperatureC.Text)).ToString();


            //3. Class
            /*
            Steps:
            1. Add new Class Library project
            2. Move/Copy existing class (from WinForm, Web, etc to Class Library)
            3. Adjust access modifier e.g. Internal to Nothing to Public
            4. Review Namespace (Just to know the namespace of Class Library)
            5. Add reference (Right-click on Reference) to the WinForm, Web, etc.
            6. Make sure to remove/comment existing class/method
            7. Use using shortcut or using static shortcut
            */

            //3.1. Class
            //var temperatureConversion = new TemperatureConversion();
            //lblOutput.Text = temperatureConversion.ConvertToFahrenheit(double.Parse(txtTemperatureC.Text)).ToString();

            //3.2. Static Class
            //lblOutput.Text = TemperatureConversion.ConvertToFahrenheit(double.Parse(txtTemperatureC.Text)).ToString();

            //lblOutput.Text = TemperatureConversionLib.TemperatureConversion.ConvertToFahrenheit(double.Parse(txtTemperatureC.Text)).ToString();

            // using static directive https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static
            lblOutput.Text = ConvertToFahrenheit(double.Parse(txtTemperatureC.Text)).ToString();

        }

        //private double ConvertToFahrenheit(double celsius)
        //{
        //    return (celsius * 9 / 5) + 32;
        //}


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
