using System;

namespace JewelryApp
{
    public abstract class Jewelry
    {
        public string Type { get; protected set; }
        public double Weight { get; protected set; }
        public double Price { get; protected set; }

        public override string ToString()
        {
            return $"Тип: {Type}, Вага: {Weight} г, Ціна: {Price} доларів";
        }
    }

    public class GoldenJewelry : Jewelry
    {
        public GoldenJewelry(string type, double weight)
        {
            Type = type;
            Weight = weight;
            Price = weight * 50; // Приблизна ціна для золота ($50 за грам)
        }
    }

    public class SilverJewelry : Jewelry
    {
        public SilverJewelry(string type, double weight)
        {
            Type = type;
            Weight = weight;
            Price = weight * 2; // Приблизна ціна для срібла ($2 за грам)
        }
    }
}