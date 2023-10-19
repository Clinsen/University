using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Виберіть фігуру для прорисовки (1 - Коло, 2 - Прямокутник, 3 - Трикутник):");
        int choice = int.Parse(Console.ReadLine());

        IShapeFactory shapeFactory;
        IShape shape = null;

        switch (choice)
        {
            case 1:
                Console.WriteLine("Введіть радіус круга:");
                double radius = GetPositiveDouble();
                shapeFactory = new CircleFactory(radius);
                shape = shapeFactory.CreateShape();
                break;
            case 2:
                Console.WriteLine("Введіть ширину прямокутника:");
                double width = GetPositiveDouble();
                Console.WriteLine("Введіть висоту прямокутника:");
                double height = GetPositiveDouble();
                shapeFactory = new RectangleFactory(width, height);
                shape = shapeFactory.CreateShape();
                break;
            case 3:
                Console.WriteLine("Введіть основу трикутника:");
                double @base = GetPositiveDouble();
                Console.WriteLine("Введіть висоту трикутника:");
                double triangleHeight = GetPositiveDouble();
                shapeFactory = new TriangleFactory(@base, triangleHeight);
                shape = shapeFactory.CreateShape();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }

        if (shape != null)
        {
            Console.WriteLine("Введіть позицію X:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть позицію Y:");
            int y = int.Parse(Console.ReadLine());

            shape.Draw(x, y);
            Console.WriteLine($"Площа фігури: {shape.CalculateArea()}");
            shape.DisplayColor("червоний");
            Console.WriteLine($"Координати центра описаного кола: {shape.GetCenterCoordinates()}");
        }
        else
        {
            Console.WriteLine("Фігура не існує.");
        }

        Console.ReadLine();
    }

    static double GetPositiveDouble()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out value) || value <= 0)
        {
            Console.WriteLine("Некоректне значення.");
        }
        return value;
    }

}