public class RegistroCompleto:Logs
{
    public string? DetalhesCancelamento;

    public RegistroCompleto(LogLevels logLevel, ControlModule logConfig) : base(logLevel, logConfig)
    {
    }

    public override void Log(string message)
    {
        // Implement logging logic here using LogLevel and LogConfig
        // For example, write to a file or database based on LogConfig
        Console.WriteLine($"[{LogLevel}] {message}");
    }
}