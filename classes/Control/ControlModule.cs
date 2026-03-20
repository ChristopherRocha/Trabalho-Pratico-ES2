public class ControlModule
{
    private static ControlModule? _instance;

    private LogOptions _logOptions;

    private ControlModule()
    {
        // Initialize default values
        _logOptions = new LogOptions(
            logFilePath: "logs/app.txt",
            logFormat: "{timestamp} - {level} - {message}",
            dbConnectionString: "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;"
        );

    }

    public static ControlModule GetInstance()
    {
        if(_instance == null)
        {
            _instance = new ControlModule();
        }   
        return _instance;
    }

    public void SetLogLevel(LogOptions logConfig)
    {
        _logOptions = logConfig;
    }

    public string GetFilePath()
    {
        return _logOptions.LogFilePath;
    }

    public string GetLogFileFormat()
    {
        return _logOptions.LogFileFormat;
    }

    public string GetDbConnectionString()
    {
        return _logOptions.DbConnectionString;
    }

    public string GetAzureConnectionString()
    {
        return _logOptions.AzureConnectionString;
    }

    public override string ToString()
    {
        string info = "";
        info+= $"Log File Path: {_logOptions.LogFilePath}\n";
        info+= $"Log Format: {_logOptions.LogFileFormat}\n";
        info+= $"DB Connection String: {_logOptions.DbConnectionString}\n";
        info+= $"Azure Connection String: {_logOptions.AzureConnectionString}\n";
        return info;
    }

}