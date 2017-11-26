using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleNameContain : IRule<Language>
    {
        string Name { get; }

        public RuleNameContain(string name)
        {
            Name = name;
        }

        public bool IsFactValide(Language fact)
        {
            return fact.Name.Contains(Name);
        }
    }
}