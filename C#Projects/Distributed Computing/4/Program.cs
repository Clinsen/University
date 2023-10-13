using System;

class Program
{
    static void Main(string[] args)
    {
        StudentCollection studentCollection = new StudentCollection();

        studentCollection.AddStudent(new Student("Smith", "Group1", "Paid", 99));
        studentCollection.AddStudent(new Student("Johnson", "Group2", "Paid", 97));
        studentCollection.AddStudent(new Student("Williams", "Group1", "Scholarship", 93));
        studentCollection.AddStudent(new Student("Jones", "Group2", "Paid", 98));
        studentCollection.AddStudent(new Student("Brown", "Group1", "Paid", 88));
        studentCollection.AddStudent(new Student("Davis", "Group3", "Paid", 100));
        studentCollection.AddStudent(new Student("Miller", "Group3", "Scholarship", 96));

        studentCollection.SortByAverageGrade();
        studentCollection.PrintGroupLists();

        // Зберегти у файл
        studentCollection.SaveToFile("students.dat");
        Console.WriteLine("\nStudents have been successfuly saved to the file!\n");

        // Зчитати з файлу
        StudentCollection loadedStudents = new StudentCollection();
        loadedStudents.LoadFromFile("students.dat");

        Console.WriteLine("\n========== Loading students from the file ==========\n");
        loadedStudents.PrintGroupLists();
    }
}
