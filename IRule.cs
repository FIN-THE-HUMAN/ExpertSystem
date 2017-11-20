using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public interface IRule<F> where F : IFact
    {
        bool IsFactValide(F fact);
        string GetApplyingResult(F fact);
    }
}