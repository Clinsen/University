public class Ingredient
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Ingredient(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
}
