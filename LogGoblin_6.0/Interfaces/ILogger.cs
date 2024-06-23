using LogGoblin_6._0.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGoblin_6._0.Interfaces
{
    internal interface ILogger
    {
        public void Info(string message);
        public void Debug(string message);
        public void Warn(string message);
        public void Error(Exception exception, string? userMessage);
        public void Fatal(Exception exception, string? userMessage);
        public void ApplyRules(LoggerOptions options);
    }
}
