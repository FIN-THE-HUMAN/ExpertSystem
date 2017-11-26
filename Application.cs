using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class Application
    {
        public Menu Menu { get; }
        public PresenterMenu Presenter{ get; }

        public Application(Menu menu, PresenterMenu presenter)
        {
            Menu = menu;
            Presenter = presenter;
        }

        public void Start()
        {
            while(!Menu.Closed)
            {
                Presenter.Present(Menu);
                Menu.Listen(Console.ReadLine());
            }
        }
    }
}