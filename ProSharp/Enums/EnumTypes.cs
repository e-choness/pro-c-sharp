﻿namespace ProSharp.Enums;

public enum Nums
{
    N1,
    N2,
    N3,
    N4
}

public enum EmployType : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}

[Flags]
public enum ContactPreference
{
    None,
    Email,
    Phone,
    Text
}
public class EnumTypes
{
    public static void GetEnumType()
    {
        Console.WriteLine(Enum.GetValuesAsUnderlyingType<Nums>());
    }

    private static string AskForBonus(EmployType type)
    {
        return type switch
        {
            EmployType.Manager => "How about stock options instead?",
            EmployType.Grunt => "You have got to be kidding...",
            EmployType.Contractor => "You already get enough cash...",
            EmployType.VicePresident => "Very good, sir",
            _ => "Who are you exactly?"
        };

    }

    public static void ShowBonus()
    {
        Console.WriteLine("=> Show bonus to grunts");
        Console.WriteLine(AskForBonus(EmployType.Grunt));
    }

    public static void AskForContract()
    {
        var emailAndPhone = ContactPreference.Email | ContactPreference.Phone;
        // This is different outcome from c sharp book
        Console.WriteLine("None? {0}", (emailAndPhone | ContactPreference.None) == emailAndPhone); // True
        Console.WriteLine("Email? {0}", (emailAndPhone | ContactPreference.Email) == emailAndPhone); // True
        Console.WriteLine("Phone? {0}", (emailAndPhone | ContactPreference.Phone) == emailAndPhone); // True
        Console.WriteLine("Text? {0}", (emailAndPhone | ContactPreference.Text) == emailAndPhone); // True
    }
}