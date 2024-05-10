namespace ProSharp;

public class SystemChar
{
    public static void CharFunctionality()
    {
        Console.WriteLine("=> char type functionality");
        char myChar = 'a';
        
        Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
        Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
        Console.WriteLine("char.IsWhiteSpace('Hello there', 5): {0}", char.IsWhiteSpace("Hello There,", 5));
        Console.WriteLine("char.IsWhiteSpace('Hello there', 6): {0}", char.IsWhiteSpace("Hello There,", 6));
        Console.WriteLine("char.IsPunctuation('?'),: {0}", char.IsPunctuation('?'));

    }
}