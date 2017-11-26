using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public interface IEventInfoReader
    {
        string Key { get; set; }
        string Description { get; set; }
        string GetKey();
        string GetDescription();
    }
}
