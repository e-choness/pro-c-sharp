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

    private static Process? WithId(int pId)
    {
        
        Process? process = null;
        try
        {
            process = Process.GetProcessById(pId);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Console.WriteLine("Here are the thread used by: {0}", process?.ProcessName);

        return process;
    }

    public static void ShowThreads()
    {
        var pId = 9192;
        Console.WriteLine($"=> Show threads in process: {pId}");

        var process = WithId(pId);
        
        var threads = process?.Threads;
        
        if (threads != null)
            foreach (ProcessThread thread in threads)
            {
                var info =
                    $"-> Thread ID: {thread.Id}\tStart Time: {thread.StartTime.ToShortTimeString()}\tPriority: {thread.PriorityLevel}";
                Console.WriteLine(info);
            }

        Console.WriteLine("==================================\n");
    }

    public static void ShowModule()
    {
        var pId = 9124;
        Console.WriteLine($"=> Show module of process: {pId}");

        var process = WithId(pId);
        ProcessModuleCollection? modules = process?.Modules;
        if (modules != null)
        {
            foreach (ProcessModule module in modules)
            {
                var info = $"-> Mod Name: {module.ModuleName}";
                Console.WriteLine(info);
            }
        }
        Console.WriteLine("===================================\n");
    }
}