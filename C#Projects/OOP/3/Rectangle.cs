class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Прямокутник розташований на позиції ({x}, {y})");
    }

    public void DisplayColor(string color)
    {
        Console.WriteLine($"Прямокутник має кольор {color}");
    }

    public string GetCenterCoordinates()
    {
        return $"({Width / 2}, {Height / 2})";
    }
}