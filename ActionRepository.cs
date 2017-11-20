using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class ActionRepository<F> : IAction where F : IFact
    {
        private FactsRepository<F> _factsRepository;
        private IRule<F> _rule;

        public ActionRepository(FactsRepository<F> factsRepository, IRule<F> rule)
        {
            _factsRepository = factsRepository;
            _rule = rule;
        }

        public string Execute()
        {
            StringBuilder s = new StringBuilder();

            foreach(F f in _factsRepository.Facts)
            {
                if (_rule.IsFactValide(f))
                {
                    s.Append(_rule.GetApplyingResult(f));
                    //s.Append(Environment.NewLine);
                }
            }

            return s.ToString();
        }
    }
}