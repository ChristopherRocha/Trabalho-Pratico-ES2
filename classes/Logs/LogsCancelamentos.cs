public class RegistroCompleto:Log
{
    public string? DetalhesCancelamento;

    public RegistroCompleto(LogLevels logLevel, ControlModule logConfig) : base(logLevel, logConfig)
    {
    }

    public override Log CreateLog(string message)
    {
        Message = $"Cancelamento realizado: {message}";
        LogLevel = LogLevels.WARNING;
        return this;
    }

    public Log CreateCancelLog(string message, string detalhesCancelamento)
    {
        Message = $"Cancelamento realizado: {message}";
        DetalhesCancelamento = detalhesCancelamento;
        LogLevel = LogLevels.WARNING;

        return this;
    }
}