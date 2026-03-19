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


    public override string ToString()
    {
        string info = "";
        info+= $"Log File Path: {_logOptions.LogFilePath}\n";
        info+= $"Log Format: {_logOptions.LogFormat}\n";
        info+= $"DB Connection String: {_logOptions.DbConnectionString}\n";
        return info;
    }

}