namespace ProSharp.Lambda;

public class Expressions
{
    private static int Add(int x, int y) => x + y;

    public static void AddTwoNumbers()
    {
        var x = 2;
        var y = 3;
        var sum = Add(x, y);
        Console.WriteLine("Add expression {0} + {1} = {2}", x, y, sum);

        x = 10;
        y = 20;
        sum = AddWrapper(x, y);
        Console.WriteLine("Add wrapper {0} + {1} = {2}", x, y, sum);
        
    }

    private static int AddWrapper(int x, int y)
    {
        return AddNumbers();

        int AddNumbers() => x + y;
    }
}