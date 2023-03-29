using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new(4, 8, 30);
            cat.print_info();

            Console.WriteLine();

            Wolf wolf = new(10, 60, 0, "Grey Wolf", "Alaska");
            wolf.print_info();
        }
    }
}
