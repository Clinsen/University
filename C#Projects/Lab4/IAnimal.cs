using System;

namespace Lab4
{
    internal interface IAnimal : IComparable, ICloneable
    {
        void MakeSound();

        string GetBreed();
    }
}