using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IAnimal[] animals = new IAnimal[4];

                // створення об'єктів
                Rabbit rabbit1 = new("Holland Lop");
                Wolf wolf1 = new("Grey Wolf");

                // додавання їх в масив
                animals[0] = rabbit1;
                animals[1] = wolf1;

                // клонування та додавання до масиву ще два об'єкта
                animals[2] = (IAnimal)rabbit1.Clone();
                animals[3] = (IAnimal)wolf1.Clone();

                // вивід масиву перед сортуванням
                Console.WriteLine("Before sorting:");
                PrintArray(animals);

                // сортування
                Array.Sort(animals);

                // вивід масиву після сортування
                Console.WriteLine("\nAfter sorting:");
                PrintArray(animals);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        static void PrintArray(IAnimal[] animals)
        {
            foreach (IAnimal animal in animals)
            {
                Console.Write(animal.GetType().Name + " - ");
                animal.MakeSound();
            }
        }
    }
}


