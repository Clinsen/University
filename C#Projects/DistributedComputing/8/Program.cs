using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Matrix matrix = new Matrix(5, 5);

        Thread thread1 = new Thread(() =>
        {
            int nonNegativeColumn = matrix.FindFirstNonNegativeColumn();
            Console.WriteLine($"Номер першого стовпця без від'ємних елементів: {nonNegativeColumn}");
        });

        Thread thread2 = new Thread(() =>
        {
            matrix.SortRowsByPositiveElementsCount();
            Console.WriteLine("Рядки матриці відсортовані за кількістю позитивних елементів.");
        });

        Thread thread3 = new Thread(() =>
        {
            int sum = matrix.SumOfRowsWithNegativeElement();
            Console.WriteLine($"Сума елементів у рядках з від'ємними елементами: {sum}");
        });

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Робота потоків завершена.");
    }
}
