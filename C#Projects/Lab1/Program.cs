using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Creating triangle ==========");
            Triangle triangle = new Triangle();
            triangle.display_triangle();

            Console.WriteLine("========== Calculating stuff ==========");
            Console.WriteLine("\nPerimeter of the triangle: " + triangle.calculate_perimeter());
            Console.WriteLine("Area of the triangle: " + triangle.calculate_area());
            Console.WriteLine("Calculating inner circle radius: " + triangle.calculate_inner_circle_radius() + "\n");
        }
    }
}