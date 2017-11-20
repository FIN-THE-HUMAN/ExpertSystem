using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public class Menu : IObservable, IView
    {
        public List<Event> Events { get; }
        public string End { get; }
        public bool Closed { get; private set; }
        public PresenterMenu Presenter;

        public Menu(string end, PresenterMenu presenter)
        {
            Events = new List<Event>();
            End = end;
            Closed = false;
            Presenter = presenter;
        }

        public void Open()
        {
            Closed = false;
        }

        public void SetPresenter(PresenterMenu presenter)
        {
            Presenter = presenter;
        }

        public void AddEvent(Event e)
        {
            Events.Add(e);
        }

        public void UpdatePresenter(string changse)
        {
            Presenter.Update(changse);
        }

        public void Listen(string key)
        {
            if (key == End)
            {
                Closed = true;
                return;
            }

            StringBuilder s = new StringBuilder();

            var EventList = from e in Events where e.Key == key select e;
            foreach(var e in EventList)
            {
                s.Append(e.Execute());
                //s.Append(Environment.NewLine);
                //s.Append(Environment.NewLine);
            }

            if (Presenter != null) UpdatePresenter(s.ToString());

        }
    }
}