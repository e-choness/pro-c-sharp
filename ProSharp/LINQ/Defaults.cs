namespace ProSharp.LINQ;

public class Defaults
{
    public static void ImmediateExecution()
    {
        Console.WriteLine("=> Immediate Execution");
        int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

        var number = (from i in numbers select i).First();
        Console.WriteLine("First is {0}", number);

        number = (from i in numbers orderby i select i).First();
        Console.WriteLine("Ordered first is {0}", number);

        number = (from i in numbers where i > 30 select i).Single();
        Console.WriteLine("Larger than 30 single is {0}", number);

    }
    public static void Set()
    {
        Console.WriteLine("=> Setting Defaults");
        int[] numbers = [];
        
        var query = from i in numbers where i > 100 select i;
        var number = query.FirstOrDefault(-1);
        Console.WriteLine("The first or default from an empty array query is {0}", number);

        number = query.SingleOrDefault(-2);
        Console.WriteLine("The single or default from an empty array query is {0}", number);

        number = query.LastOrDefault(-3);
        Console.WriteLine("The last or default from an empty array query is {0}", number);

    }
}