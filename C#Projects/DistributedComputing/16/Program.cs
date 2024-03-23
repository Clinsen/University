using System.Text;

namespace SimplexMethod {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

            int[,] table = {
                {5, 1, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 0, 0, 5},
                {1, -3, 1, 0, 1, 0, 1},
                {2, 1, 0, 0, 0, 1, 16}
            };

            double[,] result = new double[table.GetLength(1) - 1, 1];
            int[,] table_result;
            Simplex S = new Simplex(table);
            table_result = S.Calculate(result);

            Console.WriteLine("Розв'язок симплекс-таблиці:");
            for (int i = 0; i < table_result.GetLength(0); i++) {
                for (int j = 0; j < table_result.GetLength(1); j++)
                    Console.Write(table_result[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Розв'язок:");
            for (int i = 0; i < result.GetLength(0); i++) {
                Console.WriteLine("X[" + (i + 1) + "] = " + result[i, 0]);
            }
            Console.ReadLine();
        }
    }
}
