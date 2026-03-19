internal class Program
{


    static void Main(string[] args)
    {
        var controlModule = ControlModule.GetInstance();
        var logOptions = new LogOptions("DEBUG", "logs/debug.txt", "{timestamp} - {level} - {message}");

        controlModule.SetLogLevel(logOptions);

        Console.WriteLine(controlModule.ToString());
        Console.ReadLine();

    }


}





