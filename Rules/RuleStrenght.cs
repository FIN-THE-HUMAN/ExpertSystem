using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleStrenght : IRule<Language>
    {
        public TypeStrength Type { get; }

        public RuleStrenght(TypeStrength type)
        {
            Type = type;
        }

        public bool IsFactValide(Language fact)
        {
            if (fact.TypeStrength == Type) return true;
            return false;
        }
    }
}
