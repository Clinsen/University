// Адаптер для старої системи
public class OldVagonAdapter : INewVagonSystem
{
    private readonly IOldVagonSystem _oldVagonSystem;

    public OldVagonAdapter(IOldVagonSystem oldVagonSystem)
    {
        _oldVagonSystem = oldVagonSystem;
    }

    public void MatchSocket()
    {
        _oldVagonSystem.ThinSocket();
        Console.WriteLine("Зарядження через адаптер у старому вагоні.");
    }
}
