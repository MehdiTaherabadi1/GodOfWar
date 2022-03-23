using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Events;

namespace Framework.Serilog
{
    public class SerilogAdapter : Frameowork.Core.Logging.ILogger
    {
        private ILogger _logger;

        public SerilogAdapter(ILogger logger)
        {
            _logger = logger;
        }

        public void Error(Exception ex)
        {
            if (_logger.IsEnabled(LogEventLevel.Error))
            {
                string message = ex.ToString();
                _logger.Error(message);
            }
        }

        public void Info(string template, string[] parameters)
        {
            Write(LogEventLevel.Information, template, parameters);
        }

        public void Warn(string template, string[] parameters)
        {
            Write(LogEventLevel.Warning,template,parameters);
        }

        private void Write(LogEventLevel logEventLevel,
            string template, string[] parameters)
        {
            if (_logger.IsEnabled(logEventLevel))
            {
                _logger.Write(logEventLevel, template, parameters);
            }
        }
    }
}
