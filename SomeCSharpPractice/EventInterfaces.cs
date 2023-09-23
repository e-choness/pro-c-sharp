namespace SomeCSharpPractice;

public class EventInterfaces
{
    public static void DisplayResult()
    {
        Shape shape = new Shape();
        Painter1 painter1 = new(shape);
        Painter2 painter2 = new(shape);
        shape.Draw();
    }
    public interface IDrawingObject
    {
        event EventHandler BeforeDrawing;
    }
    
    public interface IShape
    {
        event EventHandler AfterDrawing;
    }

    public class Shape : IDrawingObject, IShape
    {
        public event EventHandler? PreDrawEvent;
        public event EventHandler? PostDrawEvent;

        private object objectLock = new Object();
        
        event EventHandler IDrawingObject.BeforeDrawing
        {
            add
            {
                lock (objectLock)
                {
                    PreDrawEvent += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    PreDrawEvent -= value;
                }
            }
        }
        
        event EventHandler IShape.AfterDrawing
        {
            add
            {
                lock (objectLock)
                {
                    PostDrawEvent += value;
                }
            }
            remove
            {
                lock (objectLock)
                {
                    PostDrawEvent -= value;
                }
            }
        }

        public void Draw()
        {
            PreDrawEvent?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Drawing a shape.");
            PostDrawEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Painter1
    {
        public Painter1(Shape shape)
        {
            IDrawingObject drownShape = (IDrawingObject)shape;
            drownShape.BeforeDrawing += OnDraw;
        }

        void OnDraw(object sender, EventArgs e)
        {
            Console.WriteLine($"Painter 1 receives the {nameof(IDrawingObject)} event.");
        }
    }
    
    public class Painter2
    {
        public Painter2(Shape shape)
        {
            IShape drownShape = (IShape)shape;
            drownShape.AfterDrawing += OnDraw;
        }

        void OnDraw(object sender, EventArgs e)
        {
            Console.WriteLine($"Painter 2 receives the {nameof(IShape)} event.");
        }
    }
}