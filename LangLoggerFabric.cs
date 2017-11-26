using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class LangLoggerFabric : ILoggerFabric<Language>
    {
        public ILogger<Language> GetLogger()
        {
            //choose logger
            return new LangNameLogger();
        }
    }
}
