using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleApplyingResultLangName : IRule<Language>
    {
        public string GetApplyingResult(Language fact)
        {
            StringBuilder s = new StringBuilder();
            s.Append(fact.Name.ToString());
            s.Append(Environment.NewLine);
            return s.ToString();
        }

        public virtual bool IsFactValide(Language fact)
        {
            return false;
        }
    }
}
