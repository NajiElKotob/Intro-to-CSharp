using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_DEMO
{

//Constraint - https://msdn.microsoft.com/en-us/library/d5x73970.aspx

//where T: struct
//The type argument must be a value type.

//where T : class
//The type argument must be a reference type

//where T : new()
//The type argument must have a public parameterless constructor. 

//where T : <base class or interface name>
//The type argument must be or derive from the specified base class or implement the specified interface.

//where T : U
//The type argument supplied for T must be or 
//derive from the argument supplied for U.


//Multiple constraints can be applied to the same type parameter, and the constraints themselves can be generic types, as follows
//class EmployeeList<T> where T : Employee, IEmployee, System.IComparable<T>, new()
//{
//}


    class Person
    {
        public Person(string name)
        {

        }
    }

    class GenericConstraintsPerson<T> where T : Person, new()
    {
    }


    class GenericConstraints<T> where T : class
    {
    }
}
