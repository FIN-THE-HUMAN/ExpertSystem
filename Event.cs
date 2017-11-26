using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class Event
    {
        public string Key { get; }
        public string Description { get; }
        public List<IAction> Actions { get; }

        public Event(string key, string description, IAction action)
        {
            Key = key;
            Description = description;
            Actions = new List<IAction>();
            Actions.Add(action);
        }

        public string Execute()
        {
            StringBuilder s = new StringBuilder();

            foreach(var a in Actions)
            {
                s.Append(a.Execute());
                //s.Append(Environment.NewLine);
            }

            return s.ToString();
        }
    }
}