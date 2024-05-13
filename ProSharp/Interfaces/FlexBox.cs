using System.Collections;

namespace ProSharp.Interfaces;

public class FlexBox : IEnumerable
{
    private readonly BitmapImage[] _images;
    public FlexBox()
    {
        _images =
        [
            new BitmapImage(),
            new WebImage(),
            new BitmapImage(),
            new WebImage()
        ];
    }
    
    public IEnumerator GetEnumerator() => _images.GetEnumerator();
    
}