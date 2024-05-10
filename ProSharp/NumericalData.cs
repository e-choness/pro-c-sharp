namespace ProSharp;

public class NumericalData
{
    public static void DataTypeFunctionality()
    {
        Console.WriteLine("=> Data Type Functionality.");
        
        Console.WriteLine("Max of int {0}", int.MaxValue);
        Console.WriteLine("Min of int {0}", int.MinValue);
        Console.WriteLine("Max of double {0}", double.MaxValue);
        Console.WriteLine("Min of double {0}", double.MinValue);
        Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
        Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
    }
}