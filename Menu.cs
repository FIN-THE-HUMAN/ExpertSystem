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

        public void AddEvent(Event e)
        {
            Events.Add(e);
        }

        public void UpdatePresenter(string changse)
        {
            Presenter.Update(changse);
        }

        List<Event> GetEventsByKey(string key)
        {
            List<Event> result = new List<Event>();
            foreach (var e in Events)
            {
                if (key == e.Key) result.Add(e);
            }
            return result;
        }

        public void Listen(string key)
        {
            if (key == End)
            {
                Closed = true;
                return;
            }

            StringBuilder s = new StringBuilder();

            var EventList = GetEventsByKey(key);
            foreach (var e in EventList)
            {
                s.Append(e.Execute());
            }

            if (Presenter != null) UpdatePresenter(s.ToString());
        }
    }
}