using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class MoreThenYearRule : RuleApplyingResultLangName
    {
        int Year { get; }
        public MoreThenYearRule(int year)
        {
            Year = year;
        }

        public override bool IsFactValide(Language fact)
        {
            if (fact.Year >= Year) return true;
            return false;
        }
    }
}