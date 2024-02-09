using System;
using System.Text;

class Program {
    static void Main(string[] args) {
        Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Виведення імен працівників у верхньому регістрі:");
        var employeeCollection = new EmployeeCollection();
        employeeCollection.PrintNamesInUpperCaseInParallel();

        Console.WriteLine("\nВзаємодія виробника і споживача:");
        var producerConsumer = new ProducerConsumer();
        producerConsumer.Start();

        Console.ReadLine();
    }
}
