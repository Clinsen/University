using System;
using System.Collections.Generic;

public class Dish : IComparable<Dish>
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public decimal Price { get; set; }
    public List<string> Ingredients { get; set; }

    public Dish(string name, double weight, decimal price, List<string> ingredients)
    {
        Name = name;
        Weight = weight;
        Price = price;
        Ingredients = ingredients;
    }

    public Dish()
    {
        Name = "unknown";
        Weight = 0;
        Price = 0;
        Ingredients = new List<string>();
    }

    public int CompareTo(Dish other)
    {
        return this.Price.CompareTo(other.Price);
    }
}
