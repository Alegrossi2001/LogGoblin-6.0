using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGoblin_6._0.Loggers
{
    public class LoggerOptions
    {
        //Custom Formatting
        public string? LogPrefix { get; set; }
        public string? LogSuffix { get; set; }
        public bool AddDateTime { get; set; }

        //Save To TEXT

        public string? TXTLogsFilepath { get; set; }
        public string? TXTExceptionPath { get; set; }

        //Save To JSON

        public string? JSONLogsFilepath { get; set; }
        public string? JSONExceptionsFilepath { get; set; }

        public void SetCustomFormatting(string? logPrefix, string? logSuffix, bool addDatetime = false)
        {
            this.LogPrefix = logPrefix;
            this.LogSuffix = logSuffix;
            this.AddDateTime = addDatetime;
        }
    }
}
