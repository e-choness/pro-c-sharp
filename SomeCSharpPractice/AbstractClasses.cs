namespace SomeCSharpPractice;

public class AbstractClasses
{
    public static void ShowResult1()
    {
        Console.WriteLine("Computer Parts...");
        ComputerPart mouse = new Mouse();
        mouse.WriteDescription();
        ComputerPart keyboard = new Keyboard();
        keyboard.WriteDescription();
    }
}

public abstract class ComputerPart
{
    public virtual void WriteDescription()
    {
        Console.WriteLine($"This is a {nameof(ComputerPart)}.");
    }
    
}

public class Mouse : ComputerPart
{
    public override void WriteDescription()
    {
        Console.WriteLine($"This is a {nameof(Mouse)}.");
    }
}

public class Keyboard : ComputerPart
{
    public override void WriteDescription()
    {
        Console.WriteLine($"This is a {nameof(Keyboard)}.");
    }
}
