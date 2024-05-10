namespace ProSharp;

public class BasicIO
{
    public static void BasicConsole()
    {
        Console.WriteLine("*** Basic Console I/0 ***");
        GetUserData();
    }

    private static void GetUserData()
    {
        Console.Write("Enter your name:");
        var userName = Console.ReadLine();
        Console.Write("Enter your age:");
        var userAge = Console.ReadLine();

        var prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

        Console.ForegroundColor = prevColor;
    }
}