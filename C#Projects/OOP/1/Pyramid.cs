using System;

namespace ShapesApp
{
    public class Pyramid : Shape
    {
        private double BaseLength;
        private double Height;

        public Pyramid(double baseLength, double height) : base("Піраміда")
        {
            BaseLength = baseLength;
            Height = height;
        }

        public void SetDimensions(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateVolume()
        {
            return (BaseLength * BaseLength * Height) / 3;
        }
    }
}
