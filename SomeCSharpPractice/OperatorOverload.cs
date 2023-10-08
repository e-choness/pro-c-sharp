namespace SomeCSharpPractice;

public class OperatorOverload
{
    public static void ShowResult()
    {
        Vector2 a = new(1.1, 2.2);
        Vector2 b = new(3.3, 4.4);
        var c = a / b;
        Console.WriteLine($"Vector 3 x: {c.X} y: {c.Y}");
        
        b.X = 0;
        c = a / b;
        Console.WriteLine($"Vector 3 after divided by b x is 0 x: {c.X} y: {c.Y}");
        
        b.X = 6.6f;
        b.Y = 0;
        c = a / b;
        Console.WriteLine($"Vector 3 after divided by b x is 0 x: {c.X} y: {c.Y}");

    }
}

public class Vector2
{
    public double X;
    public double Y;
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public static Vector2 operator /(Vector2 a, Vector2 b)
    {
        return new Vector2(b.X == 0? double.MaxValue:a.X / b.X, b.Y == 0? double.MaxValue: a.Y / b.Y);
    }
}