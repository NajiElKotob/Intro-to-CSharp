using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Classes (C# Programming Guide)
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes
A type that is defined as a class is a reference type. At run time, when you 
declare a variable of a reference type, the variable contains the value null 
until you explicitly create an instance of the class by using the new operator, 
or assign it an object of a compatible type that may have been created elsewhere

//[access modifier] - [class] - [identifier]
public class Customer
{
   // Fields, properties, methods and events go here...
}


public class Manager : Employee
{
    // Employee fields, properties, methods and events are inherited
    // New Manager fields, properties, methods and events go here...
}


*/

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            //Empty class
            Console.WriteLine("Empty Class");
            EmptyClass emptyClass = new EmptyClass();
            Console.WriteLine(emptyClass.ToString()); // inherits from System.Object
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 20)));

            //Class Inheritance
            //operator 1
            Operator operator1 = new Operator(); // Operator is a keywork, don't use it in real projects https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
            Console.WriteLine(operator1.Name);
            operator1.Name = "Tima";

            Console.WriteLine(operator1.Name);

            //operator 2
            Operator operator2 = operator1;
            operator2.Name = "Taline";

            Console.WriteLine(operator1.Name);

            //operator 3
            Operator operator3 = new Operator("Majd");
            Console.WriteLine(operator3.Name);

            Console.WriteLine(new string('-', 20));



            //Manager 1
            Manager manager1 = new Manager();
            manager1.Bonus = 1000;
            Console.WriteLine(manager1.ToString());

            Console.WriteLine(new string('-', 20));

            Console.ReadLine();

        }
    }
}
