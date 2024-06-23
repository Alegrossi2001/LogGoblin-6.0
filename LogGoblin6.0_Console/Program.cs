using LogGoblin_6._0.Loggers;

LogGoblin.ConsoleLogger.Info("Goddamn!");
LogGoblin.ConsoleLogger.Warn("Warning!");

LoggerOptions options = new LoggerOptions();
options.SetCustomFormatting("HEY", "JUDE", addDatetime: true);

LogGoblin.ConsoleLogger.ApplyRules(options);
LogGoblin.ConsoleLogger.Debug("New Debug!");

try
{
    int a = 10;
    int b = 0;
    int c = a / b;
}
catch(Exception e)
{
    LogGoblin.ConsoleLogger.Fatal(e);
}
