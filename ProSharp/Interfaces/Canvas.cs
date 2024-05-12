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
}