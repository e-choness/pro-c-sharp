namespace ProSharp.Interfaces;

public interface IAdvancedDrawable : IDrawable
{
    void DrawInBoundingBox(int top, int left, int bottom, int right) => Console.WriteLine($"Drawing in a bounding box of ({top}, {left}, {bottom}, {bottom})...");
    void DrawUpsideDown() => Console.WriteLine("Drawing upside down...");
}