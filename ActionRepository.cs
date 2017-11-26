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
        private ILogger<F> _logger;

        public ActionRepository(FactsRepository<F> factsRepository, IRule<F> rule, ILogger<F> logger)
        {
            _factsRepository = factsRepository;
            _rule = rule;
            _logger = logger;
        }

        public string Execute()
        {
            StringBuilder s = new StringBuilder();

            foreach(F f in _factsRepository.Facts)
            {
                if (_rule.IsFactValide(f))
                {
                    s.Append(_logger.Log(f));
                    //s.Append(Environment.NewLine);
                }
            }
            return s.ToString();
        }
    }
}