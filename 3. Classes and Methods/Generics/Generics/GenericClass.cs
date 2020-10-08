using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class GenericTest<T>
    {
        T _value;
        

        public GenericTest(T t)
        {
            _value = t;
        }

        public T GetValue()
        {
            return this._value;
        }
    }
}
