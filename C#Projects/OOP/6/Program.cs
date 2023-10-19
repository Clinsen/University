class Program
{
    static void Main(string[] args)
    {
        // Створення чисел та виразів
        IExpression a = new Number(18);
        IExpression b = new Number(17);
        IExpression c = new Number(11);
        IExpression d = new Number(8);

        // Формуємо вираз 45-(18-17)-(11+8)
        IExpression expression = new Operation('-', new Number(45), new Operation('-', a, b));
        expression = new Operation('-', expression, new Operation('+', c, d));

        // Результат обчислення виразу
        int result = expression.Evaluate();
        Console.WriteLine($"Результат виразу 45 - (18 - 17) - (11 + 8) = {result}");

        Console.ReadLine();
    }
}
