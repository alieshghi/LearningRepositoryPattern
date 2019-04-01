using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRepositoryPattern
{
    public interface IUnitofWork:IDisposable
    {
       
        IcustomerRepos Customer { get; }
        int complete();
    }
}
