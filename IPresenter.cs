using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public interface IPresenter<V, C> where V : IView 
    {
        void Present(V view);
        void Update(C changes);
    }
}