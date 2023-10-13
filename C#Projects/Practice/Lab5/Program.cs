using System;

public class Program
{
    static void Main(string[] args)
    {
        // Створення нового екземпляру класу WolfCollection
        WolfCollection wolfCollection = new WolfCollection();

        // Додавання об'єктів Wolf до колекції
        wolfCollection.AddWolf(new Wolf("Alpha", 5, "Male"));
        wolfCollection.AddWolf(new Wolf("Beta", 3, "Female"));
        wolfCollection.AddWolfGeneric(new Wolf("Charlie", 2, "Male"));
        wolfCollection.AddWolfGeneric(new Wolf("Delta", 4, "Female"));

        // Повернення кількості елементів у колекції
        Console.WriteLine("Number of wolves (using ArrayList): " + wolfCollection.Count());
        Console.WriteLine("Number of wolves (using List<>): " + wolfCollection.CountGeneric());

        // Повернення об'єкту Wolf за індексом
        Console.WriteLine("Wolf at index 0 (using ArrayList): " + wolfCollection.GetWolf(0).Name + ", " + wolfCollection.GetWolf(0).Age + ", " + wolfCollection.GetWolf(0).Gender);
        Console.WriteLine("Wolf at index 1 (using List<>): " + wolfCollection.GetWolfGeneric(1).Name + ", " + wolfCollection.GetWolf(1).Age + ", " + wolfCollection.GetWolf(1).Gender);
    }
}