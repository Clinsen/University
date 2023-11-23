using System;
using System.Threading;

namespace FunctionCalculator
{
    public class Calculator
    {
        private object lockObject = new object();
        private Random random = new Random();
        private double[] results = new double[10];
        private int argument = 0;

        public void StartCalculations()
        {
            Thread calculationThread = new Thread(CalculateFunction);
            calculationThread.Start();
            calculationThread.Join();
        }

        public void CalculateFunction()
        {
            for (int i = 0; i < results.Length; i++)
            {
                try
                {
                    double result = ComputeFunctionValue();
                    lock (lockObject)
                    {
                        results[i] = result;
                    }
                    Console.WriteLine($"Результат {i + 1}: {result}");
                }
                catch (FunctionException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                Thread.Sleep(200);
            }
        }

        public double ComputeFunctionValue()
        {
            IncrementArgument();

            if (argument < 5)
            {
                return 4 * argument * argument + 1;
            }
            else
            {
                double denominator = 3 * argument * argument + 2 * argument + 7;

                if (denominator == 0)
                {
                    throw new FunctionException("Недопустиме значення x: знаменник не може дорівнювати 0.");
                }

                return (2 * argument + 3) / denominator;
            }
        }

        public void IncrementArgument()
        {
            argument++;
        }

        public void DisplayResults()
        {
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Результат {i + 1}: {results[i]}");
            }
        }
    }
}
