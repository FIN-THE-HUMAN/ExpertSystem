using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleNameContainFabric : IRuleFabric<Language>
    {
        public IRule<Language> GetRuleInfo()
        {
            Console.Write("Choose Language Name>> ");
            string Name = Console.ReadLine();
            return new RuleNameContain(Name);
        }
    }
}
