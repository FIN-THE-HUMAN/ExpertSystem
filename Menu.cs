using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems
{
    public class Menu<T> : IObserable<T> where T : IObserver    //создать ExpertSystemMenu : Menu<ExpertSystem>
    {
        public T Observer { get; }                                                  // убрать, оставить ссылку в каждой Команде(выс. ур), в итоге связь observer и command(низ. ур) будет в фабрике
        public Dictionary<string, ConsoleCommand<T>> Commands { get; }              // заменить на новый абстрактный тип данных Команда(выс. ур), для создания которого будет фабрика
        public Dictionary<string, LangRules.AbstractRole<T>> Commands1 { get; }
        public string End { get; set; }                                             //переместить в ExpertSystem или ConsoleExpertSystem

        public Menu(T observer, string end)
        {
            Commands = new Dictionary<string, ConsoleCommand<T>>();
            Commands1 = new Dictionary<string, LangRules.AbstractRole<T>>();
            Observer = observer;
            End = end;
        }
        
        public void AddEventListener(string key, string description, ICommand<T> command)
        {
            Commands.Add(key, new ConsoleCommand<T>(description, command) );
        }

        public void AddEventListener(string key, string description, LangRules.Role action)
        {
            Commands1.Add(key, new LangRules.AbstractRole<T>(description, action, Observer));
        }

        private string ExecuteByDelegate(string key)
        {
            string result;
            if (Commands1.ContainsKey(key))
                result = Commands1[key].Execute();
            else
            {
                result = "There isn't command such ";
                result += key;
                result += '\n';
            }
            return result;
        }

        private string ExecuteByKey(string key)
        {
            string result;
            if (Commands.ContainsKey(key))
                result = Commands[key].Execute();
            else
            {
                result = "There isn't command such ";
                result += key;
                result += '\n';
            }
            return result;
        }

        public void Show()
        {
            Console.WriteLine("Choose rule application:");
            Console.WriteLine($"{End}) Exit");
            foreach (string s in Commands.Keys)
            {
                Console.Write($"{s}) ");
                Console.WriteLine(Commands[s].Description); 
            }
            Console.Write(">> ");
        }

        public void Start()
        {
            string key = "";
            while (key != End)
            {
                Show();
                key = Console.ReadLine();
                Console.WriteLine(ExecuteByKey(key));
            }
        }
    }
}