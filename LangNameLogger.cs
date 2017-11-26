using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class LangNameLogger : ILogger<Language>
    {
        public LangNameLogger()
        {

        }

        public string Log(Language fact)
        {
            StringBuilder s = new StringBuilder();
            s.Append(fact.Name.ToString());
            s.Append(Environment.NewLine);
            return s.ToString();
        }
    }
}