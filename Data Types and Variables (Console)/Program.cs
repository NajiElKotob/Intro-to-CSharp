using System;
using System.Collections.Generic;
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

            Console.WriteLine("Hello " + name);
            //Console.WriteLine("Hello {0}", name);
            //Console.WriteLine($"Hello {name}");


            Console.ReadLine();
        }
    }
}
