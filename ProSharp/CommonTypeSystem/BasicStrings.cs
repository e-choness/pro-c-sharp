using System.Runtime.CompilerServices;
using System.Text;

namespace ProSharp.CommonTypeSystem;

public class BasicStrings
{
    public static string GetValueText(string input)
    {
        return $"The value of input: {input}";
    }

    public static string GetLengthText(string input)
    {
        return $"The input {input} has {input.Length} characters.";
    }

    public static string GetUpperText(string input)
    {
        return $"The input {input} in uppercase {input.ToUpper()}";
    }

    public static string GetLowerText(string input)
    {
        return $"The input {input} in lowercase {input.ToLower()}";
    }

    public static string GetIsSubstringText(string input, string sub)
    {
        var containTesxt = input.Contains(sub) ? "contains" : "does not contain";
        return $"The input {input} {containTesxt} {sub}";
    }
    
    public static string GetReplaceText(string input, string newValue, string oldValue)
    {
        var newString = input.Replace(oldValue, newValue);
        return $"The input {input}'s {oldValue} is replaced by {newValue}, the result is {newString}";
    }

    public static void ShowConcatenation()
    {
        Console.WriteLine("=> String concatenation");
        var s1 = "Programming the ";
        var s2 = "PsychoDrill (PTP)";
        var s3 = s1 + s2;
        Console.WriteLine(s3);
    }

    public static void InterpolatedHandle()
    {
        Console.WriteLine("=> String interpolation under the covers: \a");
        var age = 4;
        var name = "Soren";
        var builder = new DefaultInterpolatedStringHandler(3, 2);
        
        builder.AppendLiteral("\tHello ");
        builder.AppendFormatted(name);
        builder.AppendLiteral(" you are ");
        builder.AppendFormatted(age);
        builder.AppendLiteral(" years old.");

        var greeting = builder.ToStringAndClear();
        Console.WriteLine(greeting);
    }

    public static void StringEquality()
    {
        Console.WriteLine("=> String equality:");
        var s1 = "Hello!";
        string s2 = "Yo!";
        
        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}", s2);
        Console.WriteLine();
        
        // Test the strings for equality
        Console.WriteLine("s1 == s2 {0}", s1 == s2);
        Console.WriteLine("s1 == Hello! {0}", s1 == "Hello!");
        Console.WriteLine("s1 = HELLO! {0}", s1 == "HELLO!");
        Console.WriteLine("s1 == hello! {0}", s1 == "hello!");
        Console.WriteLine("s1.Equals(s2) {0}", s1.Equals(s2));
        Console.WriteLine("Yo!.Equals(s2) {0}", "Yo!".Equals(s2));
    }

    public static void EqualWithRules()
    {
        Console.WriteLine("=> String equality case insensitive: ");
        var s1 = "Hello!";
        var s2 = "HELLO!";
        Console.WriteLine("s1 = {0}", s1);
        Console.WriteLine("s2 = {0}",s2);
        Console.WriteLine();
        
        Console.WriteLine("Default rules: s1={0}, s2={1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
        Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
        Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
        Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    }

    public static void Immutable()
    {
        Console.WriteLine("=> Immutable strings \a");
        string s2 = "My string";
        s2 = "My new string";
        Console.WriteLine(s2);
    }

    public static void UseBuilder()
    {
        Console.WriteLine("=> Using the StringBuilder");

        var sb = new StringBuilder("**** Awesome Games ****");
        sb.Append("\n");
        sb.AppendLine("Half Life");
        sb.AppendLine("Morrowind");
        sb.AppendLine("Deus Ex " + "2");
        sb.AppendLine("System Shock");
        
        Console.WriteLine(sb.ToString());
        sb.Replace("2", "Invisible War");
        Console.WriteLine(sb.ToString());
        Console.WriteLine("sb has {0} chars.", sb.Length);
    }
}