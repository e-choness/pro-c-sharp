namespace SomeCSharpPractice;

public class LinqSomething
{
    public static void DisplayResult()
    {
        IterateQuery();
        GetOddNumbers();
    }

    private static void IterateQuery()
    {
        int[] nums = { 97, 92, 81, 60 };

        IEnumerable<int> numsQuery = 
            from num in nums 
            where num > 90 
            select num;

        foreach (var i in numsQuery)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    private static void GetOddNumbers()
    {
        int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        var oddQuery =
            from num in numbers
            where (num % 2) != 0
            select num;

        foreach (var oddNum in oddQuery)
        {
            Console.Write(oddNum + " ");
        }
        Console.WriteLine();
    }
}