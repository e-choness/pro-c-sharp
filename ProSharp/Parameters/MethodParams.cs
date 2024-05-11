using System.Globalization;

namespace ProSharp.Parameters;

public class MethodParams
{
    private static double CalculateAverage(params double[] values)
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

    public static void ShowAverage()
    {
        Console.WriteLine("=> Show averages using Param");
        var values = new double[] { 1.0f, 2.0f, 3.0f, 5.0f };
        Console.WriteLine("{0} average is: {1}", string.Join(" ",values.Select(i=> i.ToString(CultureInfo.InvariantCulture))), CalculateAverage(values));
    }
}