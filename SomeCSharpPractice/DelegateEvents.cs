namespace SomeCSharpPractice;

public class DelegateEvents
{
    public delegate void Callback(string message);

    private static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    public static void DisplayCallbackHandlerResult()
    {
        Callback handler = DelegateMethod;
        handler("Hello delegates!");
    }
}