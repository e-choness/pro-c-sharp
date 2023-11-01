using System;

namespace SomeCSharpPractice;

public class EmailValidator
{
    public static void DisplayResults()
    {
        
    }

    private static void ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return ;
        }
    }
}