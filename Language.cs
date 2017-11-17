using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems
{
    public class Language : IFact
    {
        public string Name { get; private set; }
        public TypeDinamic TypeDinamic { get; private set; }
        public TypeStrength TypeStrength { get; private set; }
        public Execution Execution { get; private set; }
        public Level Level { get; private set; }
        public int Year { get; private set; }

        public Language(string name, TypeDinamic td, TypeStrength ts, Execution ex, Level l, int year)
        {
            Name = name;
            TypeDinamic = td;
            TypeStrength = ts;
            Execution = ex;
            Level = l;
            Year = year;
        }
    }
}
