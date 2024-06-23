using LogGoblin_6._0.Interfaces;
using LogGoblin_6._0.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGoblin_6._0.Loggers.Functions
{
    internal class ConsoleLogger : ILogger
    {
        private LoggerOptions options = new LoggerOptions();
        public void ApplyRules(LoggerOptions options)
        {
            this.options = options;
        }

        public void Debug(string message)
        {
            LogToConsole(message, ConsoleColor.Cyan);
        }

        public void Error(Exception exception, string? userMessage)
        {
            ExceptionToConsole(exception, ConsoleColor.DarkRed, userMessage);
        }

        public void Fatal(Exception exception, string? userMessage)
        {
            ExceptionToConsole(exception, ConsoleColor.Red, userMessage);
        }

        public void Info(string message)
        {
            LogToConsole(message, ConsoleColor.White);
        }

        public void Warn(string message)
        {
            LogToConsole(message, ConsoleColor.Yellow);
        }

        private void LogToConsole(string message, ConsoleColor color)
        {
            string newMessage = LogUtils.FormatMessage(message, options);
            Console.ForegroundColor = color;
            Console.WriteLine(newMessage);
            Console.ResetColor();
        }

        private void ExceptionToConsole(Exception e, ConsoleColor color, string? customMessage)
        {
            string newMessage = LogUtils.FormatExceptionDetails(e);
            Console.ForegroundColor = color;
            Console.WriteLine(newMessage);
            Console.WriteLine(customMessage);
            Console.ResetColor();
        }
    }
}
