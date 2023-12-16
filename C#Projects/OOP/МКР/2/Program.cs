class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Оберіть геометричну фігуру:");
        Console.WriteLine("1. Point");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Circle");

        int choice = int.Parse(Console.ReadLine());

        double[] parameters;
        switch (choice)
        {
            case 1:
                parameters = new double[2];
                Console.WriteLine("Введіть координати (x y):");
                string[] pointCoordinates = Console.ReadLine().Split();
                parameters[0] = double.Parse(pointCoordinates[0]);
                parameters[1] = double.Parse(pointCoordinates[1]);
                break;
            case 2:
            case 3:
                parameters = new double[1];
                Console.WriteLine("Введіть сторону (радіус):");
                parameters[0] = double.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("Невірний вибір фігури");
                return;
        }

        IShape shape = ShapeFactory.CreateShape(choice, parameters);

        Console.WriteLine($"Площа: {shape.CalculateArea()}");
        Console.WriteLine($"Периметр: {shape.CalculatePerimeter()}");
        shape.DisplayCenter();
    }
}