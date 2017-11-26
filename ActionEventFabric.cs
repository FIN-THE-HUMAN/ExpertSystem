using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class ActionEventFabric<F> : IAction where F : IFact
    {
        private FactsRepository<F> _factsRepository;
        private IRuleFabric<F> _ruleFabric;
        private ILoggerFabric<F> _loggerFabric;
        private Menu _menu;
        private IEventInfoReader _eventInfoReader;

        public ActionEventFabric(FactsRepository<F> factsRepository, IRuleFabric<F> ruleFabric, ILoggerFabric<F> loggerFabric, Menu menu, IEventInfoReader eventInfoReader)
        {
            _factsRepository = factsRepository;
            _ruleFabric = ruleFabric;
            _loggerFabric = loggerFabric;
            _menu = menu;
            _eventInfoReader = eventInfoReader;
    
        }

        public string Execute()     // подкоректировать интерфейс IAction для возможности возвращать значения разных типов
        {
            _menu.AddEvent(
                new Event(
                    _eventInfoReader.GetKey(),
                    _eventInfoReader.GetDescription(),
                    new ActionRepository<F>(_factsRepository, _ruleFabric.GetRuleInfo(), _loggerFabric.GetLogger())));
            return "new Rule added\n";    // заменить на изменяемый результат действия
        }
    }
}