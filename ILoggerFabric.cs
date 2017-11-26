﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystemDZLast
{
    public interface ILoggerFabric<F> where F : IFact
    {
        ILogger<F> GetLogger();
    }
}
