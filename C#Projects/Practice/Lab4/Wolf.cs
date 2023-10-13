using System;

namespace Lab4
{
    internal class Wolf : IAnimal
    {
        private readonly string _breed;

        public Wolf(string breed)
        {
            this._breed = breed;
        }

        public void MakeSound()
        {
            Console.WriteLine("woof!");
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
                throw new ArgumentException("This object is not a wolf nor a rabbit!");
            }
        }

        public object Clone()
        {
            return new Wolf(this._breed);
        }
    }
}