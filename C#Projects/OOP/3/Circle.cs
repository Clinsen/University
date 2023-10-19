class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Коло розташоване на позиції ({x}, {y})");
    }

    public void DisplayColor(string color)
    {
        Console.WriteLine($"Коло має кольор {color}");
    }

    public string GetCenterCoordinates()
    {
        return $"({Radius}, {Radius})";
    }
}