using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class Typisation : RuleApplyingResultLangName
    {
        public TypeDinamic Type { get; }
        
        public Typisation(TypeDinamic type)
        {
            Type = type;
        }

        public override bool IsFactValide(Language fact)
        {
            if (fact.TypeDinamic == Type) return true;
            return false;
        }
    }
}