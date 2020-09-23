using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class VAT
    {
        public decimal CalculateVAT(decimal amount)
        {
            return CalculateVAT(amount, 0.11m, 0);
        }

        public decimal CalculateVAT(decimal amount, decimal tax)
        {
            return CalculateVAT(amount, tax, 0);
        }

        public decimal CalculateVAT(decimal amount, decimal tax, decimal margin)
        {
            return (amount * tax) + margin;
        }



    }



}
