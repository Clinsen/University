public class Point : IShape
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double CalculateArea()
    {
        return 0;
    }

    public double CalculatePerimeter()
    {
        return 0;
    }

    public void DisplayCenter()
    {
        Console.WriteLine($"Центр описаного кола: ({x}, {y})");
    }
}