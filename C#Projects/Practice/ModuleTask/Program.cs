using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Створюємо список інгредієнтів для страви
        List<string> ingredients = new List<string>();
        ingredients.Add("М'ясо");
        ingredients.Add("Картопля");
        ingredients.Add("Морква");
        ingredients.Add("Цибуля");

        // Створюємо об’єкти типу Dish
        Dish dish1 = new Dish("Борщ", 300, 35.50m, ingredients);
        Dish dish2 = new Dish("Піца", 200, 45.00m, ingredients);
        Dish dish3 = new Dish("Салат", 150, 55.50m, ingredients);

        // Створюємо колекцію Stack<Dish> та додаємо в неї об’єкти типу Dish
        Stack<Dish> dishes = new Stack<Dish>();
        dishes.Push(dish1);
        dishes.Push(dish2);
        dishes.Push(dish3);

        // Виводимо на екран всі об’єкти типу Dish в порядку спадання ціни
        Console.WriteLine("Страви в порядку спадання ціни:");
        foreach (Dish dish in dishes.OrderByDescending(d => d.Price))
        {
            Console.WriteLine($"{dish.Name} - {dish.Price} грн");
        }

        // Серіалізуємо всі об’єкти типу Dish та записуємо у файл
        XmlSerializer serializer = new XmlSerializer(typeof(List<Dish>));
        using (StreamWriter sw = new StreamWriter("dishes.xml"))
        {
            serializer.Serialize(sw, dishes.ToList());
        }

        // Десеріалізуємо об’єкти типу Dish з файлу та виводимо їх на екран
        using (StreamReader sr = new StreamReader("dishes.xml"))
        {
            List<Dish> deserializedDishes = (List<Dish>)serializer.Deserialize(sr);
            Console.WriteLine("\nВідновлені об'єкти з файлу dishes.xml:");
            foreach (Dish dish in deserializedDishes)
            {
                Console.WriteLine($"{dish.Name} - {dish.Price} грн");
            }
        }

        Console.ReadKey();
    }
}
