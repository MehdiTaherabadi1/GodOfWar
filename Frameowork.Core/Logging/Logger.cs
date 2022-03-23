using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameowork.Core.Logging
{
    public static class Logger
    {
        private static ILogger Current { get; set; }

        public static void SetCurrent(ILogger logger)
        {
            Debug.Assert(Current == null);
            Current = logger;
        }
    }
}
