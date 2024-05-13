using System.Collections;

namespace ProSharp.Interfaces;

public class Canvas
{
    public static void Paint()
    {
        var bitmap = new BitmapImage();
        bitmap.Draw();
        bitmap.DrawInBoundingBox(0, 10, 10, 10);
        bitmap.DrawUpsideDown();

        if (bitmap is IAdvancedDrawable iAdvDraw)
        {
            iAdvDraw.DrawUpsideDown(); // Will get default implementation if BitmapImage does not have the implementation
        }
    }

    public static void FillContent()
    {
        Console.WriteLine("=> Having fun with a collection of different images");
        var flexBox = new FlexBox();
        var i = 1;
        foreach (var image in flexBox)
        {
            Console.WriteLine($"No.{i++} is a {image.GetType().Name}");
        }
    }
}