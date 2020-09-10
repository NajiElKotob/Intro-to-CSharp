using Basic_CRUD_with_EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_CRUD_with_EF.Data
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
