using JewelryApp;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        JewelryCatalog catalog = new JewelryCatalog();

        JewelryFactory goldFactory = new GoldenJewelryFactory();
        JewelryFactory silverFactory = new SilverJewelryFactory();

        Jewelry goldenNecklace = goldFactory.CreateJewelry("Ожерелля", 10);
        Jewelry goldenHoop = goldFactory.CreateJewelry("Обруч", 6.7);
        Jewelry silverEarrings = silverFactory.CreateJewelry("Сережки", 5.5);

        catalog.AddJewelry(goldenNecklace);
        catalog.AddJewelry(goldenHoop);
        catalog.AddJewelry(silverEarrings);

        catalog.DisplayCatalog();
    }
}