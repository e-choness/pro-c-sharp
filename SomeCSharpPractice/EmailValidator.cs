using System;

namespace SomeCSharpPractice;

public class EmailValidator
{
    public static bool ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        var parts = email.Split('@');
        if (parts.Length != 2)
        {
            // email must have exactly one @ symbol
            return false;
        }

        var localPart = parts[0];
        var domainPart = parts[1];
        if (string.IsNullOrWhiteSpace(localPart) || string.IsNullOrWhiteSpace(domainPart))
        {
            // local domain parts cannot be empty
            return false;
        }

        foreach (var c in localPart)
        {
            if (!char.IsLetterOrDigit(c) && c != '.' && c != '_' && c != '-')
            {
                // local part contains invalid character
                return false;
            }
        }

        if (domainPart.Length < 2 
            || !domainPart.Contains('.') 
            || domainPart.Split(".").Length != 2 
            || domainPart.EndsWith(".") 
            || domainPart.StartsWith("."))
        {
            // domain part is not a valid format
            return false;
        }
        
        return true;
    }
}