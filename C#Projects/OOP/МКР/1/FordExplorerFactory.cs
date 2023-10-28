public class FordExplorerFactory : IVehicleFactory
{
    public Vehicle CreateVehicle()
    {
        return new FordExplorer();
    }
}
