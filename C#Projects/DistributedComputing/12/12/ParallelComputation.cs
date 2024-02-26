using System.Diagnostics;

class ParallelComputation {
    public static TimeSpan MeasureTime(int dataLength, ref double result) {
        double partialResult = 0;
        object lockObject = new object();

        Stopwatch stopwatch = Stopwatch.StartNew();
        Parallel.For(1, dataLength + 1, () => 0.0, (i, loopState, localPartialResult) => {
            double varA = SequentialComputation.CalculateA(i);
            double varB = SequentialComputation.CalculateB(i);
            return localPartialResult + varA * varB;
        }, (localPartialResult) => {
            lock (lockObject) {
                partialResult += localPartialResult;
            }
        });
        stopwatch.Stop();

        result = partialResult; // Оновлення результату після паралельного обчислення
        return stopwatch.Elapsed;
    }
}
