public class RegistroMinimalista : Log
{
    public string DetalhesVenda = string.Empty;
    public RegistroMinimalista(LogLevels logLevel, ControlModule logConfig, string detalhesVenda) : base(logLevel, logConfig)
    {
    }

    public override Log CreateLog(string message)
    {
        Message = $"Venda realizada: {message}";
        LogLevel = LogLevels.INFO;

        return this;
    }

    public Log CreateSellLog(string message, string detalhesVenda)
    {
        Message = $"Venda realizada: {message}";
        DetalhesVenda = detalhesVenda;
        LogLevel = LogLevels.INFO;

        return this;
    }
}