using System;

namespace FunctionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Calculator calculator = new Calculator();
            calculator.StartCalculations();

            Console.WriteLine("Обчислення завершено. Результати:");
            calculator.DisplayResults();
        }
    }
}
