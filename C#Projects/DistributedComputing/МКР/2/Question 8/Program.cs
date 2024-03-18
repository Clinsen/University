using System.Diagnostics;
using System.Text;

class Program {
    static void Main() {
        Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

        // Параметри для експериментів
        int[] mValues = { 5, 10, 15, 20, 25 }; // Число рядків матриці А
        int[] nValues = { 5, 10, 15, 20, 25 }; // Число рядків і стовбців матриці B
        int[] lValues = { 5, 10, 15, 20, 25 }; // Число стовбців матриці B
        int blockSize = 2;

        foreach (int m in mValues) {
            foreach (int l in lValues) {
                Console.WriteLine($"Проводимо експеримент для m={m}, l={l}:");
                Console.WriteLine("----------------------------------------");

                double[,] A = MatrixOperations.GenerateMatrix(m, nValues[0]);
                double[,] B = MatrixOperations.GenerateMatrix(nValues[0], l);

                Stopwatch stopwatch = Stopwatch.StartNew();
                double[,] C = MatrixOperations.MultiplyMatricesBlock(A, B, blockSize);
                stopwatch.Stop();

                double a = (Math.Pow(Math.Tan(stopwatch.Elapsed.TotalMilliseconds), 2 * Math.Pow(l + 1, 3))) / m - m + 3;
                double b = Math.Pow(Math.Sin(6 + l), 0.3) / Math.Pow(stopwatch.Elapsed.TotalMilliseconds, (2 / l)) - Math.Pow(l, 2) - 3;
                Console.WriteLine($"Час виконання: {stopwatch.Elapsed.TotalMilliseconds} мілісекунд(и)");
                Console.WriteLine($"Значення формули a: {a}");
                Console.WriteLine($"Значення формули b: {b}\n");

                Console.WriteLine("Матриця A:");
                MatrixOperations.PrintMatrix(A);

                Console.WriteLine("\nМатриця B:");
                MatrixOperations.PrintMatrix(B);

                Console.WriteLine("\nМатриця C:");
                MatrixOperations.PrintMatrix(C);

                Console.WriteLine("\n\n");
            }
        }
    }
}