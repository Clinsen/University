using System;

namespace Lab4
{
    internal class Rabbit : IAnimal
    {
        private readonly string _breed;

        public Rabbit(string breed)
        {
            this._breed = breed;
        }

        public void MakeSound()
        {
            Console.WriteLine("*rabbit noises*");
        }

        public string GetBreed()
        {
            return this._breed;
        }

        public int CompareTo(object? other)
        {
            if (other == null)
                return 1;

            if (other is IAnimal otherAnimal)
            {
                return String.Compare(this._breed, otherAnimal.GetBreed());
            }
            else
            {
                throw new ArgumentException("This object is not a rabbit nor a wolf!");
            }
        }

        public object Clone()
        {
            return new Rabbit(this._breed);
        }
    }
}