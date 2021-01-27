using Numpy;
using System;
using System.Linq;

namespace NumpyNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Numpy.NET!");

            // Numpy.NET https://github.com/SciSharp/Numpy.NET
            // create a 2D-shaped NDarray<int> from an int[]
            var m = np.array(new int[] { 1, 2, 3, 4 });
            // calculate the cosine of each element
            var result = np.cos(m);
            // get the floating point data of the result NDarray back to C#
            var data = result.GetData<double>(); // double[] { 0.54030231, -0.41614684, -0.9899925 , -0.65364362 }

            Console.WriteLine( string.Join(", ", data));
            Console.ReadLine();
        }
    }
}
