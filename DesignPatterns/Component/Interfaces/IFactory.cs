﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Component.Interfaces
{
    public interface IFactory
    {
        IBird Get(string type);
    }
}
