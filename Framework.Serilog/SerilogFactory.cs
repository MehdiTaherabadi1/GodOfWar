using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Serilog
{
    public class SerilogFactory
    {
        public static Frameowork.Core.Logging.ILogger CreateForRollingFile()
        {
            var log = new LoggerConfiguration()
                .WriteTo
                .RollingFile("log-{Date}.txt", fileSizeLimitBytes: 5000000)
                .CreateLogger();

            var adpter = new SerilogAdapter(log);

            return adpter;
        }
    }
}
