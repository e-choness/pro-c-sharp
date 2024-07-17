using System.Collections;

namespace ProSharp.Interfaces;

public class FlexBox : IEnumerable
{
    private readonly IAdvancedDrawable[] _images;
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
    
    public void Add(IAdvancedDrawable image)
    {
        var enumerable = _images.Append(image);
    }
}