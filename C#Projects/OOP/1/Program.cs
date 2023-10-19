using System;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створюємо куб зі стороною 5
            Cube cube = new Cube(5);
            cube.SetSideLength(7);
            
            Console.WriteLine($"Об'єм куба: {cube.CalculateVolume()}\n");

            // Створюємо паралелограм з основою 4 і висотою 7
            Parallelogram parallelogram = new Parallelogram(4, 7);
            parallelogram.SetDimensions(2, 3);

            Console.WriteLine($"Об'єм паралелограма: {parallelogram.CalculateVolume()}\n");

            // Створюємо піраміду з основою 6 і висотою 10
            Pyramid pyramid = new Pyramid(6, 10);
            pyramid.SetDimensions(3, 5);

            Console.WriteLine($"Об'єм піраміди: {pyramid.CalculateVolume()}\n");

            Console.ReadLine();
        }
    }
}
