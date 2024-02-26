using System.Diagnostics;

class SequentialComputation {
    public static TimeSpan MeasureTime(int dataLength, ref double result) {
        Stopwatch stopwatch = Stopwatch.StartNew();
        for (int i = 1; i <= dataLength; i++) {
            double varA = CalculateA(i);
            double varB = CalculateB(i);
            result += varA * varB;
        }
        stopwatch.Stop();
        return stopwatch.Elapsed;
    }

    public static double CalculateA(int i) {
        return Math.Pow(-1, i + 1) * (Math.Cos(1.5) * i) / Math.Pow(i, 2);
    }

    public static double CalculateB(int i) {
        return 1 + (Math.Log(i) / Math.Pow((2 * (Math.Pow(i, 2)) + 1), 2)) - Math.Pow(Math.Exp(-i), 2);
    }
}
