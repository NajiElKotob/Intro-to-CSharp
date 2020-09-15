using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_and_Directories
{
    static class Utilities
    {

        public static string GetTempFile()
        {
            return DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";
        }
    }
}
