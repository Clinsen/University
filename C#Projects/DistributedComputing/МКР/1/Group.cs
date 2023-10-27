using System;

public class Group
{
    private int numberOfStudents;

    public event EventHandler<StudentEventArgs> StudentCountChanged;

    public int NumberOfStudents
    {
        get { return numberOfStudents; }
        set
        {
            if (numberOfStudents != value)
            {
                numberOfStudents = value;
                OnStudentCountChanged(new StudentEventArgs(numberOfStudents));
            }
        }
    }

    protected virtual void OnStudentCountChanged(StudentEventArgs e)
    {
        StudentCountChanged?.Invoke(this, e);
    }
}
