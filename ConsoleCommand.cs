using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems
{
    public class ConsoleCommand<T> where T : IObserver
    {
        public string Description { get; }
        public ICommand<T> Command { get; }

        public ConsoleCommand(string description, ICommand<T> command)
        {
            Description = description;
            Command = command;
        }

        public string Execute()
        {
            return Command.Execute();
        }
    }
}
