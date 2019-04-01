using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRepositoryPattern
{
   public class Address
    {
        int id;
        public Address(int id)
        {
            this.id = id;
        }
        public string AddressDescription { get; set; }
        public string postalcode { get; set; }
    }
}
