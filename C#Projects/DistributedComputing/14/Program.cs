using System.Diagnostics;

namespace _14 {
    class Program {
        static void Main(string[] args) {
            int[] array = { 6, 18, 6, 18, 3, 25, 3, 25, 96, 81, 4, -11, 85, 4, 45, 57 };

            Console.WriteLine("Bubble Sort:");
            MeasureTime(() => BubbleSort.Sort(array, 2));

            Console.WriteLine("\nShell Sort:");
            MeasureTime(() => ShellSort.Sort(array, 8));

            Console.ReadLine();
        }

        static void MeasureTime(Action action) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            action.Invoke();

            stopwatch.Stop();
            Console.WriteLine("Execution Time: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}
