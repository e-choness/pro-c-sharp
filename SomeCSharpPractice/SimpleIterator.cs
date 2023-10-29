namespace SomeCSharpPractice;

public class SimpleIterator
{
    public static void DisplayResult()
    {
        Console.WriteLine("Getting Prime Numbers.");
        foreach (int number in PrimeSequence(5, 18))
        {
            Console.Write($"{number.ToString()} ");
        }
        
    }

    private static IEnumerable<int> PrimeSequence(int firstNum, int lastNum)
    {
        if (firstNum >= lastNum) yield return 0;
        else
        {
            if (firstNum == 1) yield return 1;
            else
            {
                for (int n = firstNum; n <= lastNum; n++)
                {
                    if (IsPrime(n))
                    {
                        yield return n;
                    }
                }
            }
            
        }
        
    }

    private static bool IsPrime(int num)
    {
        if (num == 0 || num == 1) return true;
        var sqrtNum = Math.Sqrt(num);
        for (int i = 0; i < sqrtNum; i++)
        {
            if (sqrtNum % i == 0.0f)
            {
                return true;
            }
        }

        return false;
    }
}

