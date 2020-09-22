using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {

        public Employee()
        {
            Name = "Undefined";
        }

        public Employee(string name)
        {
            this.Name = name;
        }




        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }


        public override string ToString()
        {
            return $"{Name}, Salary: {Salary}";
        }
    }
}
