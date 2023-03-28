using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Matrix mtr = new Matrix(15, 15);
            mtr.FillMatrix();
            mtr.PrintMatrix();
            Console.WriteLine(mtr.CalculateTaskOne());
            Console.WriteLine(mtr.CalculateTaskTwo());
        }
    }
}