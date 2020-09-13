using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_and_Directories
{
    class ItemList
    {
        public string DisplayValue { get; set; }
        public object ObjectValue { get; set; }

        public override string ToString()
        {
            return DisplayValue;
        }
    }
}
