using System;

namespace ShapesApp
{
    // Інтерфейс для обчислення об'єму фігур
    public interface ICalculateVolume
    {
        double CalculateVolume();
    }

    // Абстрактний суперклас для фігур
    public abstract class Shape : ICalculateVolume
    {
        protected string Name;

        public Shape(string name)
        {
            Name = name;
            Console.WriteLine($"Об'єкт {Name} створено");
        }

        public abstract double CalculateVolume();
    }
}
