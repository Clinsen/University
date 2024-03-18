class Employee {
    public string Name { get; }
    public int BirthYear { get; }
    public string Position { get; }
    public double Salary { get; }

    public Employee(string name, int birthYear, string position, double salary) {
        Name = name;
        BirthYear = birthYear;
        Position = position;
        Salary = salary;
    }
}