using System;

namespace JewelryApp
{
    public abstract class JewelryFactory
    {
        public abstract Jewelry CreateJewelry(string type, double weight);
    }

    public class GoldenJewelryFactory : JewelryFactory
    {
        public override Jewelry CreateJewelry(string type, double weight)
        {
            return new GoldenJewelry(type, weight);
        }
    }

    public class SilverJewelryFactory : JewelryFactory
    {
        public override Jewelry CreateJewelry(string type, double weight)
        {
            return new SilverJewelry(type, weight);
        }
    }
}
