using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZExpretSystems
{
    public interface ICommand<T> where T : IObserver
    {
        T Observer { get; }
        string Execute();
    }
}