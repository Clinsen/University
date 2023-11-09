using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static ConcurrentQueue<Employee> employees = new ConcurrentQueue<Employee>();
    static ManualResetEventSlim manualResetEvent = new ManualResetEventSlim(true);

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Task.Factory.StartNew(() =>
        {
            for (int i = 1; i <= 10; i++)
            {
                var employee = new Employee($"Employee{i}");
                employees.Enqueue(employee);
                Console.WriteLine($"Додано {employee.Name} до колекції.");
                manualResetEvent.Set();
                Thread.Sleep(100); // імітація додавання працівника
            }
        });

        Task.Factory.StartNew(() =>
        {
            manualResetEvent.Wait();
            var employeeNamesInUpperCase = employees.AsParallel()
                .Select(employee => employee.Name.ToUpper())
                .ToList();

            foreach (var name in employeeNamesInUpperCase)
            {
                Console.WriteLine($"Ім'я у верхньому регістрі: {name}");
            }
        });

        Task.WaitAll();

        Console.WriteLine("Робота завершена.");
    }
}
