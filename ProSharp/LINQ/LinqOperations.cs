namespace ProSharp.LINQ;

public class LinqOperations
{
    public static void LinqQueryOverInts()
    {
        int[] numbers = [10, 20, 30, 40, 1, 2, 3, 8];

        var subset = from i in numbers where i < 10 select i;
        
        Console.Write("Values in subset: ");
        foreach (var i in subset)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine("subset is a: {0}", subset.GetType().Name);
        Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
    }
}