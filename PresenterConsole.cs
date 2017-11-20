using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class PresenterConsole : PresenterMenu
    {
        public override void Present(Menu menu)
        {
            Console.WriteLine("Choose rule application:");
            Console.WriteLine($"{menu.End}) Exit");

            for (int i = 0; i < menu.Events.Count; i++)
            {
                Console.Write($"{menu.Events[i].Key}) ");
                Console.WriteLine(menu.Events[i].Description);
            }
            Console.Write(">> ");
        }

        public override void Update(string changes)
        {
            Console.WriteLine(changes);
        }
    }
}