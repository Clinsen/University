class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IVehicleFactory fordFactory = new FordExplorerFactory();
        Vehicle fordExplorer = fordFactory.CreateVehicle();
        fordExplorer.ShowInfo();

        Console.WriteLine();

        IVehicleFactory lincolnFactory = new LincolnAviatorFactory();
        Vehicle lincolnAviator = lincolnFactory.CreateVehicle();
        lincolnAviator.ShowInfo();

        Console.ReadLine();
    }
}
