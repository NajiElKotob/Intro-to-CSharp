using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversionLib
{
    public static class TemperatureConversion
    {
        public static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
