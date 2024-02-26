class Results {
    public static void DisplayResults(string computationType, double result, TimeSpan timeSpan) {
        Console.WriteLine($"\n{computationType} Обчислення:");
        Console.WriteLine($"{computationType} Скалярний добуток: {result}");
        Console.WriteLine($"{computationType} Швидкість виконання: {timeSpan}");
    }
}
