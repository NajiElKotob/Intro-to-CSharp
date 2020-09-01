using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables__Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Enter your next birthday date (dd/mm/yyyy): ");
            var dob = Console.ReadLine();

            // DateTime.Parse Method https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parse
            var daysUntilBirthay = ((TimeSpan)(DateTime.Parse(dob, new CultureInfo("ar-LB", false)) - DateTime.Now)).Days;

            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.WriteLine("Hello " + name + ", " + daysUntilBirthay.ToString() + " days until your birthday");

            //ToDo
            //Console.WriteLine("Hello {0}", name);
            //Console.WriteLine($"Hello {name}");


            Console.ReadLine();
        }
    }
}
