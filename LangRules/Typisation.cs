using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems.LangRules
{
    public class Typisation : LangRule
    {
        public TypeDinamic TDynamic { get; }

        public Typisation(LangExpertSystem observer, TypeDinamic tDynamic) : base(observer)
        {
            TDynamic = tDynamic;
        }
        
        public override string Execute()
        {
            string result = "";
            for (int i = 0; i < Observer.Facts.Count; i++)
            {
                if (Observer.Facts[i].TypeDinamic == TDynamic)
                {
                    result += Observer.Facts[i].Name;
                    result += '\n';
                }
            }
            return result;
        }
    }
}
