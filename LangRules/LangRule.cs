using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems.LangRules
{
    public class LangRule : ICommand<LangExpertSystem>
    {
        public LangExpertSystem Observer { get; }

        public LangRule(LangExpertSystem observer)
        {
            Observer = observer;
        }
        
        public virtual string Execute()
        {
            return "";
        }
    }
}
