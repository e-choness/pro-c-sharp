namespace ProSharp;

public class SwitchCase
{
    public static void PatternMatchWithWhen()
    {
        Console.WriteLine("1 [C#] 2 [VB]");
        Console.WriteLine("Please pick your language preference: ");

        object? langChoice = Console.ReadLine();
        var choice = int.TryParse(langChoice?.ToString(), out int c) ? c : langChoice;

        switch (choice)
        {
            case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("VB: OOP, multithreading, and more!");
                break;
            case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("Good choice, C# is just fine.");
                break;
            default:
                Console.WriteLine("Well... good luck!");
                break;
        }
    }

    private static string FromRainbow(string colorBand)
    {
        return colorBand switch
        {
            "Red" => "#FF0000",
            "Orange" => "#FF7F00",
            "Yellow" => "#FFF00",
            "Green" => "#00FF00",
            "Blue" => "#0000FF",
            "Indigo" => "#4B0082",
            "Violet" => "#9400D3",
            _ => "#FFFFFF"
        };
    }

    public static void ChooseColor()
    {
        Console.WriteLine(FromRainbow("Cyan"));
    }

    private static string RockPaperScissors(string first, string second)
    {
        return (first.ToLower(), second.ToLower()) switch
        {
            ("rock", "paper") => "Paper wins.",
            ("rock", "scissors") => "Rock wins.",
            ("paper", "rock") => "Paper wins.",
            ("paper", "scissors") => "Scissors wins.",
            ("scissors", "rock") => "Rock wins.",
            ("scissors", "paper") => "Scissors wins.",
            (_, _) => "Tie.",
        };
    }

    public static void PlayRockPaperScissors()
    {
        Console.WriteLine(RockPaperScissors("Rock", "Paper"));
    }
}