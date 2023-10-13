using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class StudentCollection
{
    private List<Student> students;

    public StudentCollection()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void SortByAverageGrade()
    {
        students.Sort();
    }

    public void PrintGroupLists()
    {
        students.Sort((x, y) => x.Group.CompareTo(y.Group));

        string currentGroup = null;
        Console.WriteLine("Students by Groups:");
        foreach (var student in students)
        {
            if (student.Group != currentGroup)
            {
                Console.WriteLine($"\nGroup: {student.Group}");
                currentGroup = student.Group;
            }
            Console.WriteLine($"Name: {student.LastName}, Enrollment Type: {student.EnrollmentType}, Average Grade: {student.AverageGrade}");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (FileStream fs = new FileStream(fileName, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, students);
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                students = (List<Student>)formatter.Deserialize(fs);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
