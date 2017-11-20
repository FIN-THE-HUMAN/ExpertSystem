using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class FactsRepository<F> where F : IFact
    {
        public List<F> Facts { get; }

        public FactsRepository()
        {
            Facts = new List<F>();
        }

        public void AddFact(F fact)
        {
            Facts.Add(fact);
        }
    }
}