class Program {
    static void Main(string[] args) {
        Context context = new Context();

        string expression1 = "10 + 5";
        string expression2 = "20 - 8";
        string expression3 = "7 * 3";
        string expression4 = "15 / 4";

        Console.WriteLine($"{expression1} = {context.Evaluate(expression1)}");
        Console.WriteLine($"{expression2} = {context.Evaluate(expression2)}");
        Console.WriteLine($"{expression3} = {context.Evaluate(expression3)}");
        Console.WriteLine($"{expression4} = {context.Evaluate(expression4)}");
    }
}