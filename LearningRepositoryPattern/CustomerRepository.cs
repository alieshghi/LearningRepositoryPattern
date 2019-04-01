using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LearningRepositoryPattern
{
    public class CustomerRepository : Repository<Customer>, IcustomerRepos
    {
        public CustomerRepository( PluetoContext context) :base(context)
        {

        }
        public IEnumerable<Customer> GetCutomerWithAddress()
        {
            return PluetoContext.Customer.Include(c => c.Address).OrderBy(c => c.name);
        }

        //public IEnumerable<Customer> GetTopCustomer(int count)
        //{
        //    throw new NotImplementedException();
        //}


        public PluetoContext PluetoContext
        {
            get { return context as PluetoContext; }

        }


    }
}
