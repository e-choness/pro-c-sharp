using Moq;
using ProSharp.Interfaces;

namespace ProCSharpTests.Interfaces
{
    public class CanvasTests
    {
        [Test]
        public void Paint_ShouldCallBitmapImageMethods()
        {
            // Arrange
            var mockBitmap = new Mock<IAdvancedDrawable>();
            mockBitmap.Setup(b => b.DrawUpsideDown()).Verifiable();

            var bitmapImage = new BitmapImage();
            var type = typeof(BitmapImage);

            // Act
            type.GetMethod("Draw")?.Invoke(bitmapImage, null);
            type.GetMethod("DrawInBoundingBox")?.Invoke(bitmapImage, [0, 10, 10, 10]);
            type.GetMethod("DrawUpsideDown")?.Invoke(bitmapImage, null);

            if (bitmapImage is IAdvancedDrawable iAdvDraw)
            {
                iAdvDraw.DrawUpsideDown();
            }

            // Assert
            mockBitmap.Verify();
        }

        [Test]
        public void FillContent_ShouldPrintCorrectImageDetails()
        {
            // Arrange
            var flexBox = new FlexBox
            {
                new BitmapImage(),
                new BitmapImage()
            };

            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            Canvas.FillContent();

            // Assert
            const string expected = "=> Having fun with a collection of different images\n" +
                                    "No.1 is a BitmapImage\n" +
                                    "No.2 is a BitmapImage";

            Assert.That(sw.ToString().Trim().Replace("\r", ""), Is.EqualTo(expected.Trim()));
        }
    }
}