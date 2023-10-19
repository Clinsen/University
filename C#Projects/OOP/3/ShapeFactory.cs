interface IShapeFactory
{
    IShape CreateShape();
}

class CircleFactory : IShapeFactory
{
    private double _radius;

    public CircleFactory(double radius)
    {
        _radius = radius;
    }

    public IShape CreateShape()
    {
        if (_radius > 0)
        {
            return new Circle(_radius);
        }
        else
        {
            Console.WriteLine("Некоректний радіус для кола.");
            return null;
        }
    }
}

class RectangleFactory : IShapeFactory
{
    private double _width;
    private double _height;

    public RectangleFactory(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public IShape CreateShape()
    {
        if (_width > 0 && _height > 0)
        {
            return new Rectangle(_width, _height);
        }
        else
        {
            Console.WriteLine("Некоректні значення для прямокутника.");
            return null;
        }
    }
}

class TriangleFactory : IShapeFactory
{
    private double _base;
    private double _height;

    public TriangleFactory(double @base, double height)
    {
        _base = @base;
        _height = height;
    }

    public IShape CreateShape()
    {
        if (_base > 0 && _height > 0 && _base + _height > _height)
        {
            return new Triangle(_base, _height);
        }
        else
        {
            Console.WriteLine("Некоректні значення для трикутника.");
            return null;
        }
    }
}

