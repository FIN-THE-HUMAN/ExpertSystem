using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class RuleMoreThenYear : IRule<Language>
    {
        int Year { get; }
        public RuleMoreThenYear(int year)
        {
            Year = year;
        }

        public bool IsFactValide(Language fact)
        {
            if (fact.Year >= Year) return true;
            return false;
        }
    }
}