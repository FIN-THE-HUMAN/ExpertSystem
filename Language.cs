using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class Language : IFact
    {
        public string Name { get; private set; }
        public TypeDinamic TypeDinamic { get; private set; }
        public TypeStrength TypeStrength { get; private set; }
        public Execution Execution { get; private set; }
        public Level Level { get; private set; }
        public int Year { get; private set; }

        public Language(string name, TypeDinamic typeDinamic, TypeStrength typeStrength, Execution execution, Level level, int year)
        {
            Name = name;
            TypeDinamic = typeDinamic;
            TypeStrength = typeStrength;
            Execution = execution;
            Level = level;
            Year = year;
        }
    }
}