using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class ExecutingType : RuleApplyingResultLangName
    {
        public Execution Execution { get; }

        public ExecutingType(Execution execution)
        {
            Execution = execution;
        }

        public override bool IsFactValide(Language fact)
        {
            if (fact.Execution == Execution) return true;
            return false;
        }
    }
}