﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Interfaces
{
    public interface IService<T>
    {
        T Add(T o);
    }
}
