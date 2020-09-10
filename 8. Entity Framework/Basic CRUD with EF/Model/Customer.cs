using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CRUD_with_EF.Model
{
    class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public Decimal OpenBalance { get; set; }

        public bool NewsletterSubscription { get; set; }

    }
}
