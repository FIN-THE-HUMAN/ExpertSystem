using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleTypisation : IRule<Language>
    {
        public TypeDinamic Type { get; }
        
        public RuleTypisation(TypeDinamic type)
        {
            Type = type;
        }

        public bool IsFactValide(Language fact)
        {
            if (fact.TypeDinamic == Type) return true;
            return false;
        }
    }
}