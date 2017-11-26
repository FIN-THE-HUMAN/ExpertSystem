using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    //Добавить CustomRule, включающих правила, исполнение которых необходимо для его применения ; 
    //rule3.add(rule1), rule3.add(rule2) ;rule3 => if(AllrulesTrue) true;
    class Program
    {
        static void Main(string[] args)
        {
            PresenterMenu presenter = new PresenterConsole();
            Menu menu = new Menu("0", presenter);

            FactsRepository<Language> repository = new FactsRepository<Language>();
            repository.AddFact(new Language("C#",           TypeDinamic.Static, TypeStrength.Strong,Execution.Compiled,     Level.Hight, 2000));
            repository.AddFact(new Language("C",            TypeDinamic.Static, TypeStrength.Weak,  Execution.Compiled,     Level.Middle, 1972));
            repository.AddFact(new Language("C++",          TypeDinamic.Static, TypeStrength.Weak,  Execution.Compiled,     Level.Middle, 1985));
            repository.AddFact(new Language("Java",         TypeDinamic.Static, TypeStrength.Strong,Execution.Compiled,     Level.Hight, 1995));
            repository.AddFact(new Language("JavaScript",   TypeDinamic.Dynamic,TypeStrength.Weak,  Execution.Interpreted,  Level.Hight, 1971));
            repository.AddFact(new Language("Dart",         TypeDinamic.Static, TypeStrength.Weak,  Execution.Interpreted,  Level.Hight, 2011));
            repository.AddFact(new Language("Go",           TypeDinamic.Static, TypeStrength.Strong,Execution.Compiled,     Level.Hight, 2009));
            repository.AddFact(new Language("Lua",          TypeDinamic.Dynamic,TypeStrength.Strong,Execution.Interpreted,  Level.Hight, 1993));
            repository.AddFact(new Language("Lisp",         TypeDinamic.Dynamic,TypeStrength.Strong,Execution.Interpreted,  Level.Hight, 1958));
            repository.AddFact(new Language("Fortran",      TypeDinamic.Static, TypeStrength.Strong,Execution.Compiled,     Level.Hight, 1957));

            menu.AddEvent(new Event("1","Choose Languages with year >= 2000", new ActionRepository<Language>(repository, new RuleMoreThenYear(2000), new LangNameLogger())));
            menu.AddEvent(new Event("2","Choose Interpreted Languages", new ActionRepository<Language>(repository, new RuleExecutingType(Execution.Interpreted), new LangNameLogger())));
            menu.AddEvent(new Event("3","Choose Static Languages", new ActionRepository<Language>(repository, new RuleTypisation(TypeDinamic.Static), new LangNameLogger())));
            menu.AddEvent(new Event("4","Choose Strong Languages", new ActionRepository<Language>(repository, new RuleStrenght(TypeStrength.Strong), new LangNameLogger())));
            menu.AddEvent(new Event("5","Choose C Languages", new ActionRepository<Language>(repository, new RuleNameContain("C"), new LangNameLogger())));
            menu.AddEvent(new Event("6", "Make new Rule", new ActionEventFabric<Language>(repository, new RuleNameContainFabric(), new LangLoggerFabric(), menu, new EventInfoReaderConsole())));
            Application a = new Application(menu, presenter);
            a.Start();
        }
    }
}