using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class EventInfoReaderConsole : IEventInfoReader
    {
        public string Description{ get;  set; }

        public string Key{ get;  set; }

        public string GetDescription()
        {
            Console.Write("Choose event description >> ");
            return Console.ReadLine();
            
        }

        public string GetKey()
        {
            Console.Write("Choose event key >> ");
            return Console.ReadLine();
        }
    }
}
