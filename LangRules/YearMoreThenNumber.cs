using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems.LangRules
{
    public class YearMoreThenNumber : LangRule
    {
        public int Year { get; }
        
        public YearMoreThenNumber(LangExpertSystem observer, int year) : base(observer)
        {
            Year = year;
        }

        public override string Execute()
        {
            string result = "";
            for(int i = 0; i < Observer.Facts.Count; i++)
            {
                if (Observer.Facts[i].Year >= Year)
                {
                    result += Observer.Facts[i].Name;
                    result += '\n';
                } 
            }
            return result;
        }
    }
}