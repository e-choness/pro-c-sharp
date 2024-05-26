using System.Diagnostics;

namespace ProSharp.Processes;

public class ProcessHandler
{
    public static void ListAll()
    {
        Console.WriteLine("=> List all running process.");
        var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;

        foreach (var process in runningProcs)
        {
            var info = $"-> PID: {process.Id}\tName: {process.ProcessName}";
            Console.WriteLine(info);
        }
        Console.WriteLine("==============================\n");
    }
}