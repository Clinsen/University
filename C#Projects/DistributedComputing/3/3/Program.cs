using System.Text;

class Program {
    static void Main(string[] args) {
        Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

        int dataLength = 100000; // Кількість ітерацій для обчислення СД
        double sequentialResult = 0;
        double parallelResult = 0;

        // Оцінка тривалості послідовного обчислення
        TimeSpan sequentialTimeSpan = SequentialComputation.MeasureTime(dataLength, ref sequentialResult);

        // Оцінка тривалості паралельного обчислення
        TimeSpan parallelTimeSpan = ParallelComputation.MeasureTime(dataLength, ref parallelResult);

        // Виведення результатів про швидкість послідовного та паралельного обчислення
        Results.DisplayResults("'S'", sequentialResult, sequentialTimeSpan);
        Results.DisplayResults("'P'", parallelResult, parallelTimeSpan);

        // Оцінка ефективності реалізованих паралельних алгоритмів
        Evaluation.EvaluateEfficiency(sequentialTimeSpan, parallelTimeSpan);

        // Оцінка максимального прискорення законом Амдала Amdahl's Law
        Evaluation.EvaluateAmdahlSpeedup(sequentialTimeSpan, parallelTimeSpan);

        // Оцінка максимального прискорення законом Густавсона-Барсіса
        Evaluation.EvaluateGustafsonSpeedup(sequentialTimeSpan, parallelTimeSpan);
    }
}
