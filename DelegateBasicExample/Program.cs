// See https://aka.ms/new-console-template for more information


namespace DelegateBasicExampel;

// Under the namespace the delegate method is accessible to anywhere within the namespace
// delegate void LogDel(string text);

class Program
{
    delegate void LogDel(string text);
    static void Main(string[] args)
    {
        Log log = new Log();
        LogDel LogTextToScreenDel, LogTextToFileDel;
        LogTextToScreenDel = new LogDel(log.LogTextToScreen);
        LogTextToFileDel = new LogDel(log.LogTextToFile);
        LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;
        
        Console.WriteLine("Please enter your name");
        
        var name = Console.ReadLine();
        
        LogText(multiLogDel, name);
    }

    static void LogText(LogDel logDel, string text)
    {
        logDel(text);
    }

}

class Log
{
    public void LogTextToScreen(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");
    }

    public void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}