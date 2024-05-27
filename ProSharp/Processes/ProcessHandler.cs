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

    public static void WithID(int pId)
    {
        Console.WriteLine($"=> Show threads in process: {pId}");
        Process process = null;
        try
        {
            process = Process.GetProcessById(pId);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        
        Console.WriteLine("Here are the thread used by: {0}", process.ProcessName);
        var threads = process.Threads;

        foreach (ProcessThread thread in threads)
        {
            var info =
                $"-> Thread ID: {thread.Id}\tStart Time: {thread.StartTime.ToShortTimeString()}\tPriority: {thread.PriorityLevel}";
            Console.WriteLine(info);
        }
        Console.WriteLine("==================================\n");
    }
}