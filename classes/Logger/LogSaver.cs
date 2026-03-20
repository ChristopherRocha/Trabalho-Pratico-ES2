public class LogSaver: ILogSaver
{
    ControlModule LogConfig { get; set; }

    public LogSaver(ControlModule logConfig)
    {
        LogConfig = logConfig;
    }


    public void SaveInDb(Log log)
    {
        LogConfig.GetDbConnectionString();
    }

    public void SaveInFile(Log log)
    {
        LogConfig.GetFilePath();
        LogConfig.GetLogFileFormat();
    }

    public void SaveAzure(Log log)
    {
        LogConfig.GetAzureConnectionString();
    }


}