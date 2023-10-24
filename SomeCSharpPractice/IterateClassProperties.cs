using System.Reflection;

namespace SomeCSharpPractice;

public class IterateClassProperties
{
    public void DisplayResult()
    {
        IterateMembers(customer);
        DisplayDict();
    }
    
    private Customer customer = new Customer()
    {
        Id = 123,
        Name = "The Nameless One",
        RegisterDate = DateOnly.FromDateTime(DateTime.Now)
    };

    private Dictionary<string, object> dict;

    private void IterateMembers(in Customer customer)
    {
        dict??= new Dictionary<string, object?>();
        PropertyInfo[] propertyInfos = typeof(Customer).GetProperties();
        foreach (var property in propertyInfos)
        {
            Console.WriteLine($" {nameof(Customer)} - name: {property.Name} value: {property.GetValue(customer)}");
            dict.Add(property.Name, property.GetValue(customer));
        }
    }

    private void DisplayDict()
    {
        foreach (var pair in dict)
        {
            Console.WriteLine($"{nameof(dict)} - key: {pair.Key} value: {pair.Value}");
        }
    }
}

class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateOnly RegisterDate { get; set; }
    
}

