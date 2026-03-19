public class LogOptions
{
    public string LogFilePath { get; set; }
    public string LogFormat { get; set; }
    public string DbConnectionString { get; set; }

    public LogOptions(string logFilePath, string logFormat, string dbConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;")
    {
        LogFilePath = logFilePath;
        LogFormat = logFormat;
        DbConnectionString = dbConnectionString;
    }
}