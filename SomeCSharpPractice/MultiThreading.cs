using System.Threading;

namespace SomeCSharpPractice;

public class MultiThreading
{
    public static void RunThreads()
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread Here";
        Console.WriteLine(mainThread.Name);
        
        Thread upThread = new Thread(() => CountUp("CountUp Thread"));
        Thread downThread = new Thread(() => CountDown("CountDown Thread"));
        
        upThread.Start();
        downThread.Start();
    }

    private static void CountDown(String name)
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine("Thread 1: " + i + " seconds!");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Count Down Completed!");
    }

    private static void CountUp(String name)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Thread 2: " + i + " seconds!");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Count Up Completed!");
    }
    
}