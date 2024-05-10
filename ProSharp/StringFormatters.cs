namespace ProSharp;

public class StringFormatters
{
    public static void FormatNumericalData()
    {
        Console.WriteLine("The value 99999 in various formats.");
        const int number = 99999;
        Console.WriteLine("c format: {0:c}", number);
        Console.WriteLine("d9 format: {0:d9}", number);
        Console.WriteLine("f3 format: {0:f3}", number);
        Console.WriteLine("n format: {0:n}", number);
        
        Console.WriteLine("E format: {0:E}", number);
        Console.WriteLine("e format: {0:e}", number);
        Console.WriteLine("e2 format: {0:e2}", number);
        Console.WriteLine("X format: {0:X}", number);
        Console.WriteLine("x format: {0:x}", number);
    }
}