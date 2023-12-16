public class Square : IShape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        return side * side;
    }

    public double CalculatePerimeter()
    {
        return 4 * side;
    }

    public void DisplayCenter()
    {
        Console.WriteLine($"Центр описаного кола: (0, 0)");
    }
}