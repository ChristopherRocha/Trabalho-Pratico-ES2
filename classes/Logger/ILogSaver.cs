public interface ILogSaver
{
    void SaveInDb(Log log);
    void SaveInFile(Log log);
    void SaveAzure(Log log);
}