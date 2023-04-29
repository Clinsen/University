using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> students = new List<Student>
            {
                new Student("Іваненко", "КН-201", "бюджет", 95),
                new Student("Петренко", "КН-201", "платний", 99),
                new Student("Коваленко", "КН-202", "бюджет", 88),
                new Student("Сірко", "КН-203", "бюджет", 73),
                new Student("Кравченко", "КН-204", "платний", 100),
                new Student("Бондаренко", "КН-204", "платний", 96),
                new Student("Мельник", "КН-204", "платний", 97)
            };

            Console.WriteLine("Список студентів до змін:");
            PrintStudents(students);

            // Змінюємо форму навчання для студентів з високим середнім балом на платній формі навчання
            foreach (var student in students.Where(s => s.AverageScore > 98 && s.StudyForm == "платний"))
            {
                student.StudyForm = "За рахунок іменної стипендії";
            }

            // Сортуємо список студентів за середнім балом
            students = students.OrderByDescending(s => s.AverageScore).ToList();

            Console.WriteLine("\nСписок студентів після змін та сортування:");
            PrintStudents(students);

            // Записуємо інформацію про студентів у файл
            string logsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReportInfo");
            Directory.CreateDirectory(logsFolderPath);

            string filePath = Path.Combine(logsFolderPath, "students.txt");
            using (StreamWriter sw = File.CreateText(filePath))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Surname}, {student.Group}, {student.StudyForm}, {student.AverageScore}");
                }
            }

            Console.WriteLine($"\n\nІнформацію про студентів збережено у файлі: {filePath}");

            Console.ReadLine();
        }

        // Метод для виведення списку студентів у консоль
        static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Surname}, {student.Group}, {student.StudyForm}, {student.AverageScore}");
            }
        }
    }
}