using System;

namespace ShapesApp
{
    public class Cube : Shape
    {
        private double SideLength;

        public Cube(double sideLength) : base("Куб")
        {
            SideLength = sideLength;
        }

        public void SetSideLength(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(SideLength, 3);
        }
    }
}
