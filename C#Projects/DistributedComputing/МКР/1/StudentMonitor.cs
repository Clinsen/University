using System;

public class StudentMonitor
{
    public void Subscribe(Group group)
    {
        group.StudentCountChanged += HandleStudentCountChanged;
    }

    public void Unsubscribe(Group group)
    {
        group.StudentCountChanged -= HandleStudentCountChanged;
    }

    private void HandleStudentCountChanged(object sender, StudentEventArgs e)
    {
        Console.WriteLine($"Number of students in the group: {e.NumberOfStudents}");
    }
}
