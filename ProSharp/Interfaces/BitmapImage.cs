namespace ProSharp.Interfaces;

public class BitmapImage : IAdvancedDrawable
{
    public void Draw() => Console.WriteLine($"{GetType().Name} is drawing...");

    public void DrawInBoundingBox(int top, int left, int bottom, int right) =>
        Console.WriteLine($"{GetType().Name} is drawing in a bounding box of ({top}, {left}, {bottom}, {bottom})...");

    public void DrawUpsideDown() => Console.WriteLine($"{GetType().Name} is drawing upside down");

}