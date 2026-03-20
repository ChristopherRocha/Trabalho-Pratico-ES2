public abstract class Log
{
    protected LogLevels LogLevel { get; set; }
    protected string Message { get; set; } = string.Empty;

    public Log(LogLevels logLevel, ControlModule logConfig)
    {
        LogLevel = logLevel;

    }

    public abstract Log CreateLog(string message);
}