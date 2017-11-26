using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public interface ILogger<F> where F : IFact
    {
        string Log(F fact);
    }
}
