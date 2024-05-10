namespace ProSharp.TypeConversions;

public class Bytes
{
    public static void ProcessBytes()
    {
        byte b1 = 100;
        byte b2 = 250;

        try
        {
            byte sum = checked((byte)(b1 + b2));
            Console.WriteLine("Sum = {0}", sum);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}