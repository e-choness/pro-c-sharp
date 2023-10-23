namespace SomeCSharpPractice;

public class AsyncScenarios
{
    private static readonly Button s_downloadButton = new();
    private static readonly Button s_calculateButton = new();

    private static readonly HttpClient s_HttpClient = new();

    private static readonly IEnumerable<string> s_urlList = new string[]
    {
        "https://www.google.com",
        "https://www.microsoft.com",
        "https://www.facebook.com",
        "https://www.yahoo.com"
    };

    private static void Calculate()
    {
        static DamageResult CalculateDamageDone()
        {
            return new DamageResult()
            {
                // Some calculation here on damage output
            };
        }

        s_calculateButton.Clicked += async (o, e) =>
        {
            var damageResult = await Task.Run(() => CalculateDamageDone());
            DisplayDamage(damageResult);
        };
    }

    private static void DisplayDamage(DamageResult damage)
    {
        Console.WriteLine(damage.Damage);
    }
    
    public static void DisplayResult()
    {
        
    }
}

class Button
{
    public Func<object, object, Task>? Clicked
    {
        get;
        internal set;
    }
}

class DamageResult
{
    public int Damage
    {
        get { return 0; }
    }
}

class User
{
    public bool isEnabled
    {
        get;
        set;
    }

    public int id
    {
        get;
        set;
    }
}