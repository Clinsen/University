using System;

namespace ShapesApp
{
    public class Parallelogram : Shape
    {
        private double BaseLength;
        private double Height;

        public Parallelogram(double baseLength, double height) : base("Паралелограм")
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
            return BaseLength * Height;
        }
    }
}
