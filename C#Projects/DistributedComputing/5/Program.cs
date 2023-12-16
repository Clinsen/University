using System;

namespace FunctionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Calculator calculator = new Calculator();
            CustomTimer timer = new CustomTimer(100, calculator);

            calculator.StartCalculations();

            Console.WriteLine("\nОбчислення завершено. Результати:");
            calculator.DisplayResults();
        }
    }
}
