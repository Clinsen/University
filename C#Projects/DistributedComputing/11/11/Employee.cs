public class Employee {
    public string Name { get; set; }

    public Employee(string name) {
        Name = name;
    }

    public string GetNameInUpperCase() {
        return Name.ToUpper();
    }
}
