using System.Globalization;

namespace ProSharp.Parameters;

public class MethodParams
{
    public static double CalculateAverage(params double[] values)
    {
        Console.WriteLine("I have {0} doubles.", values.Length);

        double sum = 0;
        if (values.Length == 0)
        {
            return sum;
        }

        foreach (var value in values)
        {
            sum += value;
        }

        return sum / values.Length;
    }
}