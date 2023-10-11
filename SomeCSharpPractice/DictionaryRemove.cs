namespace SomeCSharpPractice;

public class DictionaryRemove
{

    public static void ShowResult()
    {
        var dict = new Dictionary<string, string>()
        {
            { "12345", "I'm unique" }
        };

        Console.WriteLine(dict.Remove("1111"));
    }
}

