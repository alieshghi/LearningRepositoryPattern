using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRepositoryPattern
{
    public class Customer
    {
        int id;
        public Customer(int id)
        {
            this.id = id;
        }
        
        public String name { get; set; }
        public String phone { get; set; }
        public List<Address> Address { get; set; }


    }
}
