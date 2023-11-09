using System;
using System.Threading;

namespace FunctionCalculator
{
    class Calculator
    {
        private object lockObject = new object();
        private int[] resultsPart1 = new int[5];
        private int[] resultsPart2 = new int[5];

        public void StartCalculations()
        {
            Thread part1Thread = new Thread(CalculatePart1);
            Thread part2Thread = new Thread(CalculatePart2);

            part1Thread.Start();
            part2Thread.Start();

            part1Thread.Join();
            part2Thread.Join();
        }

        public void CalculatePart1()
        {
            for (int i = 0; i < resultsPart1.Length; i++)
            {
                int x = new Random().Next(1, 6);

                try
                {
                    int result = ComputePart1Value(x);
                    lock (lockObject)
                    {
                        resultsPart1[i] = result;
                    }
                }
                catch (FunctionException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                Thread.Sleep(200);
            }
        }

        public void CalculatePart2()
        {
            Thread.Sleep(3200);

            for (int i = 0; i < resultsPart2.Length; i++)
            {
                int x = new Random().Next(6, 11);

                try
                {
                    int result = ComputePart2Value(x);
                    lock (lockObject)
                    {
                        resultsPart2[i] = result;
                    }
                }
                catch (FunctionException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                Thread.Sleep(200);
            }
        }

        public int ComputePart1Value(int x)
        {
            if (x == 1)
            {
                throw new FunctionException("Недопустиме значення x: функція не визначена для x = 1.");
            }
            return 4 * x * x + 1;
        }

        public int ComputePart2Value(int x)
        {
            int denominator = 3 * x * x + 2 * x + 7;

            if (denominator == 0)
            {
                throw new FunctionException("Недопустиме значення x: знаменник не може дорівнювати 0.");
            }

            return (2 * x + 3) / denominator;
        }

        public void DisplayResults()
        {
            Console.WriteLine("Частина 1 функції:");
            for (int i = 0; i < resultsPart1.Length; i++)
            {
                Console.WriteLine($"Результат {i + 1}: {resultsPart1[i]}");
            }

            Console.WriteLine("Частина 2 функції:");
            for (int i = 0; i < resultsPart2.Length; i++)
            {
                Console.WriteLine($"Результат {i + 1}: {resultsPart2[i]}");
            }
        }
    }
}
