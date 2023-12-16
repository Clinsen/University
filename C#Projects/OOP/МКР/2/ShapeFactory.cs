public static class ShapeFactory
{
    public static IShape CreateShape(int choice, params double[] parameters)
    {
        switch (choice)
        {
            case 1:
                return new Point(parameters[0], parameters[1]);
            case 2:
                return new Square(parameters[0]);
            case 3:
                return new Circle(parameters[0]);
            default:
                throw new ArgumentException("Невірний вибір фігури");
        }
    }
}
