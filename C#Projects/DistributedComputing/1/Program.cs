using System;
using System.Collections;
using System.Collections.Generic;

// Клас представлення об'єкту Wolf
public class Wolf
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// Клас WolfCollection для зберігання колекції об'єктів Wolf з використанням ArrayList
public class WolfCollection
{
    private ArrayList wolves = new ArrayList();

    public void AddWolf(Wolf wolf)
    {
        wolves.Add(wolf);
    }

    public void IterateWolves()
    {
        foreach (Wolf wolf in wolves)
        {
            Console.WriteLine($"Name: {wolf.Name}, Age: {wolf.Age}");
        }
    }

    public Wolf GetWolf(int index)
    {
        if (index >= 0 && index < wolves.Count)
        {
            return (Wolf)wolves[index];
        }
        else
        {
            return null;
        }
    }
}

// Клас GenericWolfCollection для зберігання колекції об'єктів Wolf з використанням List<>
public class GenericWolfCollection
{
    private List<Wolf> wolves = new List<Wolf>();

    public void AddWolf(Wolf wolf)
    {
        wolves.Add(wolf);
    }

    public void IterateWolves()
    {
        foreach (Wolf wolf in wolves)
        {
            Console.WriteLine($"Name: {wolf.Name}, Age: {wolf.Age}");
        }
    }

    public Wolf GetWolf(int index)
    {
        if (index >= 0 && index < wolves.Count)
        {
            return wolves[index];
        }
        else
        {
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Використання WolfCollection з ArrayList
        WolfCollection wolfCollection = new WolfCollection();

        wolfCollection.AddWolf(new Wolf { Name = "Alpha", Age = 5 });
        wolfCollection.AddWolf(new Wolf { Name = "Beta", Age = 3 });

        wolfCollection.IterateWolves();
        Console.WriteLine("Info about Wolf at index 1:");
        Wolf wolfAtIndex1 = wolfCollection.GetWolf(1);

        if (wolfAtIndex1 != null)
        {
            Console.WriteLine($"Name: {wolfAtIndex1.Name}, Age: {wolfAtIndex1.Age}\n");
        }
        else
        {
            Console.WriteLine("Wolf not found.\n");
        }

        // Використання GenericWolfCollection з List<>
        GenericWolfCollection genericWolfCollection = new GenericWolfCollection();

        genericWolfCollection.AddWolf(new Wolf { Name = "Gamma", Age = 4 });
        genericWolfCollection.AddWolf(new Wolf { Name = "Delta", Age = 2 });

        genericWolfCollection.IterateWolves();
        Console.WriteLine("Info about Wolf at index 0:");
        Wolf wolfAtIndex0 = genericWolfCollection.GetWolf(0);

        if (wolfAtIndex0 != null)
        {
            Console.WriteLine($"Name: {wolfAtIndex0.Name}, Age: {wolfAtIndex0.Age}\n");
        }
        else
        {
            Console.WriteLine("Wolf not found.\n");
        }
    }
}
