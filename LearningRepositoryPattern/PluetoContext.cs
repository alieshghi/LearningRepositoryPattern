using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LearningRepositoryPattern
{
    public class PluetoContext:DbContext
    {
        public PluetoContext()
: base("name=PlutoContext")
{
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Address> Address { get; set; }
      
    }
}
