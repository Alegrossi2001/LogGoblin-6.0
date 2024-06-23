using LogGoblin_6._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGoblin_6._0.Loggers.Functions
{
    internal class TextLogger : ILogger
    {
        public void ApplyRules(LoggerOptions options)
        {
            throw new NotImplementedException();
        }

        public void Debug(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception, string? userMessage)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Exception exception, string? userMessage)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            Console.WriteLine("Deep deep down in the forest " + message);
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }
    }
}
