using LogGoblin_6._0.Interfaces;
using LogGoblin_6._0.Loggers.Functions;

namespace LogGoblin_6._0.Loggers
{
    public class LogGoblin
    {
        public static LogGoblin ConsoleLogger
        {
            get
            {
                ConsoleLogger logger = new ConsoleLogger();
                consoleLogger.ilogger = logger;
                return consoleLogger;
            }
        }
        private static readonly LogGoblin consoleLogger = new LogGoblin();
        public static LogGoblin TXTLogger
        {
            get
            {
                TextLogger logger = new TextLogger();
                txtLogger.ilogger = logger;
                return txtLogger;
            }
        }
        private static readonly LogGoblin txtLogger = new LogGoblin();
        public static LogGoblin JSONLogger
        {
            get
            {
                JSONLogger logger = new JSONLogger();
                jsonLogger.ilogger = logger;
                return jsonLogger;
            }
        }
        private static readonly LogGoblin jsonLogger = new LogGoblin();
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        private ILogger ilogger;
        public void Info(string message)
        {
            ilogger.Info(message);
        }

        public void Debug(string message)
        {
            ilogger.Debug(message);
        }

        public void Warn(string message)
        {
            ilogger.Warn(message);
        }

        public void Error(Exception exception, string? userMessage = null)
        {
            ilogger.Error(exception, userMessage);
        }

        public void Fatal(Exception exception, string? userMessage = null)
        {
            ilogger.Fatal(exception, userMessage);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void ApplyGlobalRules(LoggerOptions options)
        {
            ConsoleLogger.ilogger.ApplyRules(options);
            TXTLogger.ilogger.ApplyRules(options);
            JSONLogger.ilogger.ApplyRules(options);
        }

        public void ApplyRules(LoggerOptions options)
        {
            ilogger.ApplyRules(options);
        }
    }
}
