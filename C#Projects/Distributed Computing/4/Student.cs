using System;

[Serializable]
public class Student : IComparable<Student>
{
    public string LastName { get; set; }
    public string Group { get; set; }
    public string EnrollmentType { get; set; }
    public double AverageGrade { get; set; }

    public Student(string lastName, string group, string enrollmentType, double averageGrade)
    {
        LastName = lastName;
        Group = group;
        EnrollmentType = enrollmentType;
        AverageGrade = averageGrade;
    }

    public int CompareTo(Student other)
    {
        return other.AverageGrade.CompareTo(AverageGrade);
    }

    public override string ToString()
    {
        return $"{LastName}, Group: {Group}, Enrollment Type: {EnrollmentType}, Average Grade: {AverageGrade}";
    }
}
