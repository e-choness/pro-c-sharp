using System.Runtime.CompilerServices;

namespace ProSharp.CommonTypeSystem;

public class BasicStrings
{
    public static void Functionalities()
    {
        Console.WriteLine("=> Basic String Functionality");
        
        const string firstName = "Freddy";
        Console.WriteLine("Value of firstName: {0}", firstName);
        Console.WriteLine("firstName has {0} characters.", firstName.Length);
        Console.WriteLine("firstName in uppercase {0}", firstName.ToUpper());
        Console.WriteLine("firstName in lowercase {0}", firstName.ToLower());
        Console.WriteLine("firstName contains the letter y: {0}", firstName.Contains('y'));
        Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
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
}