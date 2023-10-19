class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // У новому вагоні
        INewVagonSystem newVagon = new NewVagonSystem();
        newVagon.MatchSocket(); // Ноутбук заряджається в новому вагоні.

        // У старому вагоні через адаптер
        IOldVagonSystem oldVagon = new OldVagonSystem();
        INewVagonSystem adapter = new OldVagonAdapter(oldVagon);
        adapter.MatchSocket(); // Ноутбук не може заряджатися в старому вагоні через вузьку розетку.

        Console.ReadLine();
    }
}
