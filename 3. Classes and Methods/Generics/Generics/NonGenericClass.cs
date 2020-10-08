using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class NonGenericClass
    {
        int _value;

        public NonGenericClass(int value)
        {
            this._value = value;
        }

        public int GetValue()
        {
            return this._value;
        }
    }




}
