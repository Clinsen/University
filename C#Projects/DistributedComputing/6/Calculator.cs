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
            Thread firstThread = new Thread(CalculateFirstPart);
            Thread secondThread = new Thread(CalculateSecondPart);

            firstThread.Start();
            secondThread.Start();

            firstThread.Join();
            secondThread.Join();
        }

        private void CalculateFirstPart()
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    double result = ComputeFirstPart();
                    lock (lockObject)
                    {
                        results[i] = result;
                    }
                    Console.WriteLine($"Результат (Частина 1, Потік 1): {result}");
                }
                catch (FunctionException ex)
                {
                    Console.WriteLine($"Помилка (Частина 1, Потік 1): {ex.Message}");
                }

                Thread.Sleep(200);
            }
        }

        private void CalculateSecondPart()
        {
            Console.WriteLine("Потік 2 очікує умову.");
            while (argument < 5)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nУмова виконана. Потік 2 розпочинає обчислення.");

            for (int i = 5; i < results.Length; i++)
            {
                try
                {
                    double result = ComputeSecondPart();
                    lock (lockObject)
                    {
                        results[i] = result;
                    }
                    Console.WriteLine($"Результат (Частина 2, Потік 2): {result}");
                }
                catch (FunctionException ex)
                {
                    Console.WriteLine($"Помилка (Частина 2, Потік 2): {ex.Message}");
                }

                Thread.Sleep(200);
            }
        }

        private double ComputeFirstPart()
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

        private double ComputeSecondPart()
        {
            IncrementArgument();

            return Math.Sin(argument);
        }

        public void IncrementArgument()
        {
            lock (lockObject)
            {
                argument++;
            }
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
