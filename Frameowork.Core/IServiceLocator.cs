﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameowork.Core
{
    public interface IServiceLocator
    {
        T GetInstance<T>();
        void Release(object obj);
    }
}
