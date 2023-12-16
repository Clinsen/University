public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public void DisplayCenter()
    {
        Console.WriteLine($"Центр описаного кола: (0, 0)");
    }
}