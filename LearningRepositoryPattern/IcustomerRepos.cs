using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRepositoryPattern
{
    interface IcustomerRepos :IRepository<Customer>
    {
        //IEnumerable<Customer> GetTopCustomer(int count);
        IEnumerable<Customer> GetCutomerWithAddress();
        
    }
}
