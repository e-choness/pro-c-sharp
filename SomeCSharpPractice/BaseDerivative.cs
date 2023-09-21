namespace SomeCSharpPractice;

public class BaseDerivative
{
    public static void DisplayResult()
    {
        var circle = new Circle(42);
        var rectangle = new Rectangle(4, 3);
        var container = new ShapeContainer();
        
        circle.Draw();
        rectangle.Draw();
        
        Console.WriteLine("Adding a new circle and rectangle.");
        container.AddShape(circle);
        container.AddShape(rectangle);
        
        Console.WriteLine("Now updating both circle and rectangle area.");
        circle.Update(12);
        rectangle.Update(6,7);
    }
}

public class ShapeEventArgs : EventArgs
{
    public ShapeEventArgs(double area)
    {
        Area = area;
    }
    public double Area { get; }
}

public abstract class Shape
{
    protected double _area;

    public double Area
    {
        get => _area;
        set => _area = value;
    }

    public event EventHandler<ShapeEventArgs> ShapeChanged;

    public abstract void Draw();

    protected virtual void OnShapeChanged(ShapeEventArgs e)
    {
        ShapeChanged?.Invoke(this, e);
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        _area = Math.PI * double.Pow(_radius, 2);
    }

    public void Update(double radius)
    {
        _radius = radius;
        _area = Math.PI * double.Pow(_radius, 2);
        OnShapeChanged(new ShapeEventArgs(_area));
    }

    protected override void OnShapeChanged(ShapeEventArgs e)
    {
        Console.WriteLine("Circle is changing to another shape...");
        base.OnShapeChanged(e);
    }

    public override void Draw()
    {
        Console.WriteLine($"The area of {nameof(Circle) } is {_area}");
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
        _area = _width * _height;
    }

    public void Update(double width, double height)
    {
        _width = width;
        _height = height;
        _area = _width * _height;
        OnShapeChanged(new ShapeEventArgs(_area));
    }

    protected override void OnShapeChanged(ShapeEventArgs e)
    {
        Console.WriteLine("Rectangle is changing to another shape...");
        base.OnShapeChanged(e);
    }
    
    public override void Draw()
    {
        Console.WriteLine($"The area of {nameof(Rectangle)} is {_area}");
    }
}

public class ShapeContainer
{
    private readonly List<Shape> _list;

    public ShapeContainer()
    {
        _list = new();
    }

    public void AddShape(Shape shape)
    {
        _list.Add(shape);
        shape.ShapeChanged += HandleShapeChanged;
    }

    private void HandleShapeChanged(object sender, ShapeEventArgs e)
    {
        if (sender is Shape shape)
        {
            Console.WriteLine($"Received event. The shape area is now {e.Area}");
            shape.Draw();
        }
    }
}