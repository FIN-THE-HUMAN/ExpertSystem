using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            LangExpertSystem expertSystem = new LangExpertSystem();
            expertSystem.AddFact(new Language("C", TypeDinamic.Static, TypeStrength.Weak, Execution.Compiled, Level.Middle, 1972));
            expertSystem.AddFact(new Language("C#", TypeDinamic.Static, TypeStrength.Strong, Execution.Compiled, Level.Hight, 2000));
            expertSystem.AddFact(new Language("Python", TypeDinamic.Dynamic, TypeStrength.Strong, Execution.Interpreted, Level.Hight, 1991));
            expertSystem.AddFact(new Language("Dart", TypeDinamic.Static, TypeStrength.Strong, Execution.Interpreted, Level.Hight, 2011));
            expertSystem.AddFact(new Language("JavaScript", TypeDinamic.Dynamic, TypeStrength.Weak, Execution.Interpreted, Level.Hight, 1995));

            Menu<LangExpertSystem> menu = new Menu<LangExpertSystem>(expertSystem, "0");


            menu.AddEventListener("1", "Choose languages with Year >= 2000", new LangRules.YearMoreThenNumber(expertSystem, 2000));
            menu.AddEventListener("2", "Choose languages with Dynamic typisation", new LangRules.Typisation(expertSystem, TypeDinamic.Dynamic));
            
            menu.Start();
            //Console.ReadKey();
        }
    }
}