using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWow.Model
{
    class Order
    {
        public int Id { get; set; }

        public Item Item { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }

        public int Quantity { get; set; }


        public override string ToString()
        {
            return $"{Item.Name} - {Quantity} x {Item.Price}  {Item.Price * Quantity}";
        }
    }
}
