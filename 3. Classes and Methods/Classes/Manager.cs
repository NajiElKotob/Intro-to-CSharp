using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Bonus: {Bonus}";
        }

    }
}
