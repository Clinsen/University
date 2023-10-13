using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Matrix
    {
        private int rows;
        private int cols;
        private int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrix = new int[rows, cols];
        }

        public void FillMatrix()
        {
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
        }

        public void PrintMatrix()
        {
            Console.WriteLine("================ Printing the matrix ================");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int CalculateTaskOne()
        {
            Console.WriteLine("\n\n================ Number of columns that have at least one element that is equal to 0 ================");
            int counter = 0;

            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        counter++;
                        break;
                    }
                }
            }
            return counter;
        }

        public int CalculateTaskTwo()
        {
            Console.WriteLine("\n\n================ Row index number of identical numbers in which is the highest ================");
            int row_index = 0;
            int temp_index = 0;

            int counter = 0;
            int temp_counter = 0;

            List<int> numbers = new List<int>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!numbers.Contains(matrix[i, j]))
                    {
                        numbers.Add(matrix[i, j]);
                    }
                    else if (i > 0 && j == 0)
                    {
                        temp_index++;
                        temp_counter = 0;
                        numbers.Clear();
                    }
                    else if (numbers.Contains(matrix[i, j]))
                    {
                        temp_counter++;
                        if (temp_counter > counter)
                        {
                            counter = temp_counter;
                            row_index = temp_index;
                        }
                    }
                }
            }
            return row_index;
        }
    }
}
