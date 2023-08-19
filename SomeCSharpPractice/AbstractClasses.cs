namespace SomeCSharpPractice;

public class AbstractClasses
{
    public static void ShowResult()
    {
        ComputerPart mouse = new Mouse();
        mouse.WriteDescription();
        ComputerPart keyboard = new Keyboard();
        keyboard.WriteDescription();
    }
}

public abstract class ComputerPart
{
    private string Name => "Computer Part";
    public virtual void WriteDescription()
    {
        Console.WriteLine($"This is a {Name}.");
    }
    
}

public class Mouse : ComputerPart
{
    private string Name => "Mouse";
    public override void WriteDescription()
    {
        Console.WriteLine($"This is a {Name}.");
    }
}

public class Keyboard : ComputerPart
{
    private string Name => "Keyboard";

    public override void WriteDescription()
    {
        Console.WriteLine($"This is a {Name}.");
    }
}
