using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRepositoryPattern
{
    public class Customer
    {
        public int id { get; set; }
        public String name { get; set; }
        public String phone { get; set; }
        public List<Address> Address { get; set; }


    }
}
