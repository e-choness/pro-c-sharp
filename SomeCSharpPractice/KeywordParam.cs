namespace SomeCSharpPractice;

public static class KeywordParam
{
    public static double Checkout(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}