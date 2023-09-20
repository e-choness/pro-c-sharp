namespace SomeCSharpPractice;

public static class DelegateEvents
{
    public delegate void Callback(string message);

    private static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    public static void DisplayCallbackHandlerResult()
    {
        MethodClass methodClass = new();
        Callback callback1 = methodClass.Method1;
        Callback callback2 = methodClass.Method2;
        Callback handler = DelegateMethod;

        Callback allDelegates = callback1 + callback2 + handler;
        allDelegates("Hello delegates!");
        MethodWithCallback(3,4, allDelegates);
        
        Console.WriteLine("Removing callback 1.");
        allDelegates -= callback1;
        allDelegates("Goodbye callback 1");
        Console.WriteLine("Removing callback 2.");
        allDelegates -= callback2;
        allDelegates("Goodbye callback 2");
        allDelegates -= handler;
        // alldelegates("Goodbye handler.");
    }

    public static void MethodWithCallback(int param1, int param2, Callback callback)
    {
        callback($"The sum of two number is: {(param1+param2).ToString()}");
    }
}

public class MethodClass
{
    public void Method1(string message)
    {
        Console.WriteLine($"{message} is from method 1.");
    }

    public void Method2(string message)
    {
        Console.WriteLine($"{message} is from method 2.");
    }
}