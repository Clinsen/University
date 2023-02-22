using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Triangle
    {
        private double side1;
        private double side2;
        private double side3;

        // Конструктор
        public Triangle()
        {
            try
            {
                Console.WriteLine("\nEnter the first side of the triangle: ");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second side of the triangle: ");
                side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the third side of the triangle: ");
                side3 = Convert.ToDouble(Console.ReadLine());

                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new InvalidTriangle("Side of your triangle cannot be less or equal than 0!");
                }
                if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                {
                    throw new InvalidTriangle("This is not a triangle!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: " + e.Message + "\nApplying standard values to the triangle...");
                side1 = 1.0;
                side2 = 2.0;
                side3 = 2.0;
            }
        }


        // Get, Set для сторін трикутника
        public double First_side { get { return side1; } set { side1 = value; } }
        public double Second_side { get { return side2; } set { side2 = value; } }
        public double Third_side { get { return side3; } set { side3 = value; } }


        // Вивід трикутника
        public void display_triangle()
        {
            Console.WriteLine("\n========== Displaying the triangle ==========\n\nFirst side of the triangle: " + side1 + "\nSecond side of the triangle: " + side2 + "\nThird side of the triangle: " + side3 + "\n");
        }


        // Методи для обрахунку площі, периметра, точки перетину медіан
        public double calculate_perimeter()
        {
            return side1 + side2 + side3;
        }
        public double calculate_area()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }
        public string calculate_centroid()
        {
            double x = 0.0;
            double y = 0.0;
            string centroid = "(" + Convert.ToString(x) + ", " + Convert.ToString(y) + ")";
            return centroid;
        }
        ~Triangle()
        {
            
        }
    }
}
