using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Class1 : Interface1
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool MyFunc(int value)
        {
            return false;
        }

        public void MySub(int value)
        {
            throw new NotImplementedException();
        }
    }


    class Class2 : Interface1
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool MyFunc(int value)
        {
            return true;
        }

        public void MySub(int value)
        {
            throw new NotImplementedException();
        }
    }
}
