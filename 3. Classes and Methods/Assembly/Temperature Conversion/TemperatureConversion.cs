using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversion
{
   internal static class TemperatureConversion
    {

        internal static double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }


    }
}

