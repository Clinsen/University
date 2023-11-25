using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static ConcurrentBag<Employee> employees = new ConcurrentBag<Employee>();
    static ConcurrentQueue<string> messages = new ConcurrentQueue<string>();
    static ManualResetEventSlim manualResetEvent = new ManualResetEventSlim(false);

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Створення колекції працівників та виведення їх імен у верхньому регістрі за допомогою PLINQ
        InitializeEmployees();
        DisplayEmployeeNamesInUpperCase();

        // 2. Виробник / Споживач з одним виробником та одним споживачем
        Task.Factory.StartNew(Producer);
        Task.Factory.StartNew(Consumer);

        DisplayMessages();

        Task.WaitAll();

        Console.WriteLine("\nРобота завершена.");
    }

    // Задача 1
    static void InitializeEmployees()
    {
        for (int i = 1; i <= 10; i++)
        {
            employees.Add(new Employee($"Employee{i}"));
        }
    }

    static void DisplayEmployeeNamesInUpperCase()
    {
        var employeeNamesInUpperCase = employees
            .AsParallel()
            .Select(employee => employee.Name.ToUpper())
            .ToList();

        Console.WriteLine("Задача 1: Імена працівників у верхньому регістрі:");
        foreach (var name in employeeNamesInUpperCase)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();
    }

    // Задача 2
    static void Producer()
    {
        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(200);
            string message = $"Виробник: Виготовлено товар {i}.";
            messages.Enqueue(message);
            Console.WriteLine(message);
            manualResetEvent.Set();
        }
    }

    static void Consumer()
    {
        manualResetEvent.Wait();

        string message;
        while (messages.TryDequeue(out message))
        {
            Console.WriteLine($"Споживач: Отримано повідомлення: {message}");
        }
    }

    static void DisplayMessages()
    {
        Console.WriteLine("\nЗадача 2: Повідомлення про події:");

        while (!manualResetEvent.IsSet || messages.Count > 0)
        {
            string message;
            if (messages.TryDequeue(out message))
            {
                Console.WriteLine(message);
            }
        }
    }
}