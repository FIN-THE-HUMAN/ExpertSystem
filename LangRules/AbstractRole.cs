using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems.LangRules
{
    public delegate bool Role(LangExpertSystem expertSystem);

    public class AbstractRole<T> where T : IObserver
    {
        public string Description { get; }
        public Role Command { get; }
        public T ExpertSystem { get; }

        public AbstractRole(string description, Role command, T expertSystem)
        {
            Description = description;
            Command = command;
            ExpertSystem = expertSystem;
        }

        public virtual string Execute()
        {
            return "";
        }
    }
}
