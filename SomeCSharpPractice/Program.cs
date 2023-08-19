namespace SomeCSharpPractice;

static class Program
{
    static void Main(string[] args)
    {
        // This is a param keyword practices, it's like C++ ...
        Console.WriteLine(KeywordParam.Checkout(1.0));
        Console.WriteLine(KeywordParam.Checkout(2.0, 3.0));
        Console.WriteLine(KeywordParam.Checkout(5.0, 6.0, 7.0));
        Console.WriteLine(KeywordParam.Checkout(new double[]{9.0, 10.0, 11.0, 12.0, 13.0}));
        
        // Output A 2D array values
        TwoDimenArray twoDimenArray = new TwoDimenArray();
        
        // Inheritance in C#, abstract class indicates missing components and it is to be completed via inheritance classes 
        AbstractClasses.ShowResult();
        
        // ToString() can also be overridden
        ToStringOverride.DisplayResult();
    }
    
}
