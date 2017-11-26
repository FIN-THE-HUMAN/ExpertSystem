using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleExecutingType : IRule<Language>
    {
        public Execution Execution { get; private set; }

        public RuleExecutingType(Execution execution)
        {
            Execution = execution;
        }

        public bool IsFactValide(Language fact)
        {
            if (fact.Execution == Execution) return true;
            return false;
        }
    }
}