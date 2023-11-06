using System;
using System.Threading;

namespace FunctionCalculator
{
    class Calculator
    {
        private object lockObject = new object();
        private Random random = new Random();
        private int[] results = new int[10];

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
                int x = random.Next(1, 11);

                try
                {
                    int result = ComputeFunctionValue(x);
                    lock (lockObject)
                    {
                        results[i] = result;
                    }
                }
                catch (FunctionException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                Thread.Sleep(200);
            }
        }

        public int ComputeFunctionValue(int x)
        {
            if (x < 5)
            {
                return 4 * x * x + 1;
            }
            else if (x > 5)
            {
                int denominator = 3 * x * x + 2 * x + 7;

                if (denominator == 0)
                {
                    throw new FunctionException("Недопустиме значення x: знаменник не може дорівнювати 0.");
                }

                return (2 * x + 3) / denominator;
            }
            else
            {
                throw new FunctionException("Недопустиме значення x: функція не визначена для x = 5.");
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
