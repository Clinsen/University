using System.Collections.Concurrent;

public class EmployeeCollection {
    private ConcurrentQueue<Employee> employees = new ConcurrentQueue<Employee>();

    public EmployeeCollection() {
        employees.Enqueue(new Employee("Bob"));
        employees.Enqueue(new Employee("Ross"));
        employees.Enqueue(new Employee("Will"));
        employees.Enqueue(new Employee("Smith"));
        employees.Enqueue(new Employee("Steve"));
        employees.Enqueue(new Employee("Jobs"));
    }

    public void PrintNamesInUpperCaseInParallel() {
        employees.AsParallel().ForAll(employee => {
            Console.WriteLine(employee.GetNameInUpperCase());
        });
    }
}
