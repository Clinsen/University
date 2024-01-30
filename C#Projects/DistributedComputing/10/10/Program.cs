using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TPL {
    class Program {
        static double LessThanFive(double x) {
            return 4 * Math.Pow(x, 2) + 1;
        }

        static double MoreOrEqualsThanFive(double x) {
            return (2 * x + 3) / (3 * Math.Pow(x, 2)) + 2 * x + 7;
        }

        static void Main() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть початкове значення x: ");
            double startX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть кінцеве значення x: ");
            double endX = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть крок табулювання: ");
            double step = Convert.ToDouble(Console.ReadLine());

            List<double> results = new List<double>();

            Parallel.ForEach(GenerateRange(startX, endX, step), x => {
                double result = x < 5 ? LessThanFive(x) : MoreOrEqualsThanFive(x);

                lock (results) {
                    results.Add(result);
                }
            });

            Console.WriteLine("Результати табулювання:");

            for (int i = 0; i < results.Count; i++) {
                Console.WriteLine($"f({startX + i * step}) = {results[i]}");
            }

            Console.ReadLine();
        }

        static IEnumerable<double> GenerateRange(double start, double end, double step) {
            double current = start;
            while (current <= end) {
                yield return current;
                current += step;
            }
        }
    }
}
