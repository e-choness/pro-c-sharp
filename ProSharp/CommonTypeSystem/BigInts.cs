using System.Numerics;

namespace ProSharp.CommonTypeSystem;

public class BigInts
{
    public static void UseBigInteger()
    {
        Console.WriteLine("=> Use BigInteger");
        
        var biggy = BigInteger.Parse("9999999999999999999999999999999999999999");
        
        Console.WriteLine("Value of biggy is {0}", biggy);
        Console.WriteLine("Is biggy an even value: {0}", biggy.IsEven);
        Console.WriteLine("Is biggy a power of two: {0}", biggy.IsPowerOfTwo);

        var reallyBiggy = BigInteger.Parse("88888888888888888888888888888888888888888888888");
        Console.WriteLine("Value of reallyBiggy is {0}", reallyBiggy);

        var reallyReallyBiggy = biggy * reallyBiggy;
        Console.WriteLine("Value of really really Biggy is {0}", reallyReallyBiggy);
    }
}