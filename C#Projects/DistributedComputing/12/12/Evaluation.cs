class Evaluation {
    public static void EvaluateEfficiency(TimeSpan sequentialTime, TimeSpan parallelTime) {
        double speedup = sequentialTime.TotalMilliseconds / parallelTime.TotalMilliseconds;
        double efficiency = speedup / Environment.ProcessorCount;
        Console.WriteLine($"\nЕфективність: {efficiency}");
    }

    public static void EvaluateAmdahlSpeedup(TimeSpan sequentialTime, TimeSpan parallelTime) {
        double P = sequentialTime.TotalMilliseconds / parallelTime.TotalMilliseconds;
        double threadCount = Environment.ProcessorCount;
        double speedupAmdahl = 1 / ((1 - P) + (P / threadCount));
        Console.WriteLine($"\nПрискорення (Закон Амдала): {speedupAmdahl}");
    }

    public static void EvaluateGustafsonSpeedup(TimeSpan sequentialTime, TimeSpan parallelTime) {
        double speedupGustafson = sequentialTime.TotalMilliseconds / parallelTime.TotalMilliseconds;
        Console.WriteLine($"Прискорення (Закон Густавсона-Барсіса): {speedupGustafson}");
    }
}
