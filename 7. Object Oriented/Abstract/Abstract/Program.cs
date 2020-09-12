using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
abstract (C# Reference)
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-define-abstract-properties

The abstract modifier indicates that the thing being modified has a missing or 
incomplete implementation. The abstract modifier can be used with classes, 
methods, properties, indexers, and events. Use the abstract modifier in a 
class declaration to indicate that a class is intended only to be a base 
class of other classes, not instantiated on its own. Members marked as abstract
must be implemented by non-abstract classes that derive from the abstract class.
*/

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
        {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
        };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }

    public abstract class Shape
    {
        private string name;

        public Shape(string s)
        {
            // calling the set accessor of the Id property.
            Id = s;
        }

        public string Id
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return $"{Id} Area = {Area:F2}";
        }
    }




    public class Square : Shape
    {
        private int side;

        public Square(int side, string id)
            : base(id)
        {
            this.side = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return side * side;
            }
        }
    }

    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string id)
            : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return radius * radius * System.Math.PI;
            }
        }
    }

    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height, string id)
            : base(id)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return width * height;
            }
        }
    }

}
