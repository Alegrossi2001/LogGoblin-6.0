using LogGoblin_6._0.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGoblin_6._0.Utils
{
    internal static class LogUtils
    {
        public static string FormatExceptionDetails(Exception exception)
        {
            return $"----- TURBOLOGGER -----\n" +
                   $"ERROR DATETIME   : {DateTime.Now.ToShortDateString()} : {DateTime.Now.ToShortTimeString()}\n" +
                   $"ERROR TYPE       : {exception.GetType().Name}\n" +
                   $"ERROR MESSAGE    : {exception.Message}\n" +
                   $"ERROR STACK TRACE: \n{exception.StackTrace}\n" +
                   $"----------------------";
        }

        public static string FormatMessage(string initialMessage, LoggerOptions options)
        {
            initialMessage = $"{options.LogPrefix} {initialMessage} {options.LogSuffix}";
            if (options.AddDateTime)
            {
                initialMessage = $"{DateTime.Now.ToShortDateString()} : {DateTime.Now.ToShortTimeString()} - {initialMessage}";
            }
            return initialMessage;

            
        }
    }
}
