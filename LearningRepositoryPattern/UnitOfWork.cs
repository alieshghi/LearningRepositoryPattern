using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRepositoryPattern
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly PluetoContext context;
        public UnitOfWork(PluetoContext context)
        {
            this.context = context;
            Customer   = new CustomerRepository(context);
        }
        



        public IcustomerRepos Customer { get; }

        public int complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
