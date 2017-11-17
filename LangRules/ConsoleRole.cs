using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems.LangRules
{
    public class ConsoleRole : AbstractRole<LangExpertSystem>
    {
        public ConsoleRole(string description, Role command, LangExpertSystem expertSystem) : base(description, command, expertSystem)
        {
            
        }

        public override string Execute()
        {
            string result = "";
            for (int i = 0; i < ExpertSystem.Facts.Count; i++)
            {
                if (Command.Invoke(ExpertSystem))
                {
                    result += ExpertSystem.Facts[i].Name;
                    result += '\n';
                }
            }
            return result;
        }
    }
}
