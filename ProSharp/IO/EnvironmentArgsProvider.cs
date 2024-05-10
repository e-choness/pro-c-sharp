namespace ProSharp.IO;

public class EnvironmentArgsProvider
{
    public static void ShowEnvironmentDetails()
    {
        foreach (var drive in Environment.GetLogicalDrives())
        {
            Console.WriteLine("Drive: {0}", drive);
        }
    
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Core Version: {0}", Environment.Version);
        Console.WriteLine("Current machine name: {0}", Environment.MachineName);
        Console.WriteLine("Current user name: {0}", Environment.UserName);
        Console.WriteLine("Current user domain name: {0}", Environment.UserDomainName);
    }

}