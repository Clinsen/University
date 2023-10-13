using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = { { 0, 1, 2 }, { 3, 0, 5 }, { 6, 7, 0 } };
            TwoDimensionalArrayHelper<int> intArrayHelper = new TwoDimensionalArrayHelper<int>(intArray);

            Console.WriteLine("Columns with at least one zero element: " + intArrayHelper.CountColumnsWithZeroElement());
            Console.WriteLine("Row with most equal elements: " + intArrayHelper.RowWithMostEqualElements());

            CustomClass[,] customArray = { { new CustomClass(1), new CustomClass(2) }, { new CustomClass(3), new CustomClass(3) } };
            TwoDimensionalArrayHelper<CustomClass> customArrayHelper = new TwoDimensionalArrayHelper<CustomClass>(customArray);

            Console.WriteLine("Columns with at least one zero element: " + customArrayHelper.CountColumnsWithZeroElement());
            Console.WriteLine("Row with most equal elements: " + customArrayHelper.RowWithMostEqualElements());
        }
    }
}
