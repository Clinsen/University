class Triangle : IShape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Трикутник розташований на позиції ({x}, {y})");
    }

    public void DisplayColor(string color)
    {
        Console.WriteLine($"Трикутник має кольор {color}");
    }

    public string GetCenterCoordinates()
    {
        return $"({Base / 2}, {Height / 2})";
    }
}