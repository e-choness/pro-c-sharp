namespace ProSharp.CommonTypeSystem;

public class StringParser
{
    public static void ParseFromStrings()
    {
        Console.WriteLine("=> Data type parsing:");

        var b = bool.Parse("True");
        Console.WriteLine("Value of b: {0}", b);

        var d = double.Parse("99.884");
        Console.WriteLine("Value of d: {0}", d);

        var i = int.Parse("8");
        Console.WriteLine("Value of i: {0}", i);

        var c = char.Parse("w");
        Console.WriteLine("Value of c: {0}", c);

        try
        {
            b = bool.Parse("Hello");
            Console.WriteLine("Value of b again: {0}", b);
        }
        catch (Exception e)
        {
            Console.WriteLine("The error is {0}", e.Message);
        }
    }

    public static void ParseFromStringWithTryParse()
    {
        Console.WriteLine("=> Data type parsing with TryParse");
        if (bool.TryParse("True", out bool b1))
        {
            Console.WriteLine("Value of b1: {0}", b1);
        }
        else
        {
            Console.WriteLine("Default value of b1: {0}", b1);
        }

        var value = "Hello";
        if (double.TryParse(value, out double d1))
        {
            Console.WriteLine("Value of d: {0}", d1);
        }
        else
        {
            Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d1);
        }
    }
}