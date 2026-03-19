public class RegistroMinimalista : Logs
{
    public string DetalhesVenda;
    public RegistroMinimalista(LogLevels logLevel, ControlModule logConfig, string detalhesVenda) : base(logLevel, logConfig)
    {
        DetalhesVenda = detalhesVenda;
    }

    public override void Log(string message)
    {
        // Implement logging logic here using LogLevel and LogConfig
        // For example, write to a file or database based on LogConfig
        Console.WriteLine($"[{LogLevel}] {message}");
    }
}