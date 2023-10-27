class Program
{
    static void Main(string[] args)
    {
        Group group = new Group();
        StudentMonitor studentMonitor = new StudentMonitor();

        studentMonitor.Subscribe(group);

        group.NumberOfStudents = 10;
        group.NumberOfStudents = 15;

        studentMonitor.Unsubscribe(group);

        group.NumberOfStudents = 8;
    }
}
