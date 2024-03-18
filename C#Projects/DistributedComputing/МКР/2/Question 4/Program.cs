class Program {
    static void Main(string[] args) {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var employees = InitializeEmployees();
        DisplayEmployeesInReverseOrder(employees);

        Console.WriteLine("\nРобота завершена.");
    }

    static List<Employee> InitializeEmployees() {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Robert", 1985, "Manager", 50000),
            new Employee("Bob", 1990, "Developer", 60000),
            new Employee("Patrick", 1980, "Designer", 55000),
            new Employee("Mads", 1988, "Tester", 52000),
            new Employee("Leya", 1975, "Analyst", 70000)
        };

        return employees;
    }

    static void DisplayEmployeesInReverseOrder(List<Employee> employees) {
        var employeesInReverseOrder = employees
            .AsParallel()
            .OrderByDescending(employee => employee.Name)
            .ToList();

        Console.WriteLine("Працівники у зворотньому порядку:");
        foreach (var employee in employeesInReverseOrder) {
            Console.WriteLine($"Ім'я: {employee.Name}, Рік народження: {employee.BirthYear}, Посада: {employee.Position}, Оклад: {employee.Salary}");
        }
        Console.WriteLine();
    }
}