public abstract class Logs
{
    protected LogLevels LogLevel { get; set; }
    protected ControlModule LogConfig { get; set; }

    public Logs(LogLevels logLevel, ControlModule logConfig)
    {
        LogLevel = logLevel;
        LogConfig = logConfig;
    }

    public abstract void Log(string message);
}