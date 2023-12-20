using Accord.Neuro;
using Accord.Neuro.ActivationFunctions;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;

class Program
{
    static void Main()
    {
        // кількість входів та виходів
        int inputCount = 2;
        int outputCount = 1;

        // нейромережа з 2-ма входами, 3-ма нейронами в прихованому шарі та 1 виходом
        ActivationNetwork network = new ActivationNetwork(new SigmoidFunction(), inputCount, 3, outputCount);

        // Вхідні дані для навчання
        double[][] input =
        {
            new double[] { 0, 0 },
            new double[] { 0, 1 },
            new double[] { 1, 0 },
            new double[] { 1, 1 }
        };

        // вихідні дані
        double[][] output =
        {
            new double[] { 0 },
            new double[] { 1 },
            new double[] { 1 },
            new double[] { 0 }
        };

        // метод навчання
        var teacher = new BackPropagationLearning(network);

        // навчання
        double error = 1.0;
        int iteration = 0;
        while (error > 0.01 && iteration < 1000)
        {
            error = teacher.RunEpoch(input, output);
            iteration++;
        }

        // Приклад використання:
        double[] result = network.Compute(new double[] { 0, 1 });
        Console.WriteLine($"Результат: {result[0]}");

    }
}
