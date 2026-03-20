public class LogOptions
{
    public string LogFilePath { get; set; }
    public string LogFileFormat { get; set; }
    public string DbConnectionString { get; set; }
    public string AzureConnectionString { get; set; }

    public LogOptions(string logFilePath, string logFormat, string dbConnectionString = "MeuConnectionString", string azureConnectionString = "MinhaAzureConnectionString")
    {
        LogFilePath = logFilePath;
        LogFileFormat = logFormat;
        DbConnectionString = dbConnectionString;
        AzureConnectionString = azureConnectionString;
    }
}