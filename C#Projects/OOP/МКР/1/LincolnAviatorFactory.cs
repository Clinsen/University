public class LincolnAviatorFactory : IVehicleFactory
{
    public Vehicle CreateVehicle()
    {
        Console.WriteLine("Введіть параметр 1 для Lincoln Aviator:");
        string param1 = Console.ReadLine();

        Console.WriteLine("Введіть параметр 2 для Lincoln Aviator:");
        int param2 = Convert.ToInt32(Console.ReadLine());

        return new LincolnAviator(param1, param2);
    }
}
