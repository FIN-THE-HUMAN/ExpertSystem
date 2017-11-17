using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems
{
    public class ExpertSystem<IFact> : IObserver
    {
        public List<IFact> Facts { get; }

        public ExpertSystem()
        {
            Facts = new List<IFact>(); 
        }
        
        public void AddFact(IFact fact)
        {
            Facts.Add(fact);
        }
    }
}