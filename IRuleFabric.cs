using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public interface IRuleFabric<F> where F : IFact
    {
        IRule<F> GetRuleInfo();
    }
}
