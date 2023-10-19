class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IJewelryFactory goldenFactory = new GoldenJewelryFactory();
        IJewelryFactory silverFactory = new SilverJewelryFactory();

        IJewelry goldenEarrings = goldenFactory.CreateEarrings();
        IJewelry silverRing = silverFactory.CreateRing();

        IJewelry goldenPendant = goldenFactory.CreatePendant();
        IJewelry silverBracelet = silverFactory.CreateBracelet();
        

        Console.WriteLine($"Назва: {goldenEarrings.GetName()}, Ціна: {goldenEarrings.GetPrice()}");
        Console.WriteLine($"Назва: {silverRing.GetName()}, Ціна: {silverRing.GetPrice()}");
        Console.WriteLine($"Назва: {goldenPendant.GetName()}, Ціна: {goldenPendant.GetPrice()}");
        Console.WriteLine($"Назва: {silverBracelet.GetName()}, Ціна: {silverBracelet.GetPrice()}");

        Console.ReadLine();
    }
}
